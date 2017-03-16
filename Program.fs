module Main


let player = "harding"
let host = "localhost"
let port = 25575
let pass = "wFDzmsdJ"
open RCon
let send, recv = connect host port pass
recv.Add(printfn "%A")

open Minecraft

let slowSend s =
    System.Threading.Thread.Sleep 200
    printfn "%s" s
    send s

let cursor = startAt slowSend "harding" 
cursor
// |> silent
|> setTime Day
|> setWeather Clear
// |> face North
|> stepForward
|> withBlock "Stone"
|> placeBlock
|> stepForward
|> placeBlock
// |> resetPosition
|> ignore




cursor 
|> withBlock "air"
|> face North
|> stepForward
|> drawLine 50

cursor 
|> withBlock "air"
|> face North
|> stepDown
|> stepForward
|> drawLine 50
// |> stepForward
// |> drawRect 5 5
// |> stepUp
// |> stepForward
// |> turnRight
// |> stepForward
// |> face North
// |> withBlock "pumpkin"
// |> drawRect 3 3
// // |> stepDown
// // |> drawRect 5 5
// |> ignore

