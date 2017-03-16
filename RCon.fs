module RCon

open System.IO
open System
open System.Net.Sockets

type MsgType = SERVERDATA_AUTH = 3 | SERVERDATA_AUTH_RESPONSE = 2 | SERVERDATA_EXECCOMMAND = 2 | SERVERDATA_RESPONSE_VALUE = 0

type Msg = { Id: int; Type: MsgType; Body : string  }

let mutable private _id = 15

let send (stream : BinaryWriter) (msgtype : MsgType) (msg:string)  =
    let id : int = System.Threading.Interlocked.Increment(&_id)
    // RCon is message based not streaming so we need to make sure we send the entire buffer in one packet
    let ms = new MemoryStream()
    let writer = new BinaryWriter(ms)
    let size = 8 + msg.Length + 2
    writer.Write size
    writer.Write id
    writer.Write(int(msgtype))
    msg |> System.Text.ASCIIEncoding.ASCII.GetBytes |> writer.Write
    writer.Write 0s // null terminate string + extra null per rcon proto
    let buffer = ms.ToArray()
    stream.Write buffer
    stream.Flush()
    id

let decode (buffer : byte[]) size =
    if size > 9 then
        let reader = new BinaryReader(new MemoryStream(buffer))
        let msgsz = reader.ReadInt32()
        let id = reader.ReadInt32()
        let mtype : MsgType = reader.ReadInt32() |> enum
        let msg = new string(reader.ReadChars(msgsz - 10))
        Some { Id = id; Type = mtype; Body = msg }
    else
        None

let connect host port password =
    let conn = new TcpClient(host, port)
    if not conn.Connected then failwith "Unable to connect"
    let stream = conn.GetStream()
    let writer = new BinaryWriter(stream)
    send writer MsgType.SERVERDATA_AUTH password |> ignore
    let response = new Event<Msg>()
    let rec recv (stream : NetworkStream)  = async {
        let buffer = Array.zeroCreate<byte> 4096
        let! size = stream.AsyncRead(buffer)
        if size = 0 then do! Async.Sleep 100
        // assume this is one message
        match decode buffer size with
        | Some msg -> response.Trigger msg
        | None -> ()
        return! (recv stream)
    }
    conn.ReceiveTimeout <- 1000
    recv stream |> Async.Start
    // return send function and receive Event
    (send writer MsgType.SERVERDATA_EXECCOMMAND), response.Publish