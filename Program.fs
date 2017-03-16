module Main

let player = "harding"
let host = "localhost"
let port = 25575
let pass = "wFDzmsdJ"
open RCon
let send, recv = connect host port pass
recv.Add(printfn "%A")

open Minecraft

let sleep (i:int) = System.Threading.Thread.Sleep i
let slowSend s =
    sleep 250
    printfn "%s" s
    send s

let cursor = startAt slowSend "harding" 
cursor
|> setTime Day
|> setWeather Clear
|> face North
|> stepForward
|> withBlock "Stone"
|> placeBlock
|> stepForward
|> placeBlock
|> turnRight
|> drawRect 4 4
// |> resetPosition
|> ignore




cursor 
|> setTime Day
|> withBlock "Red Wool"
|> face North
|> stepForward
|> filledPyramid "Air" "White Stained Glass" 25
//|> fillPyramid 21
|> ignore

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

