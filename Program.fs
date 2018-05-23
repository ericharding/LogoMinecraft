module Main

let player = "harding"
let host = "localhost"
let port = 25575
let pass = "wFDzmsdJ"
open RCon
let send, recv = connect host port pass
recv.Add(printfn "%A")

open Minecraft
open Castle

let slowSend s =
    sleep 200
    printfn "%s" s
    send s

let cursor = 
    startAt slowSend "harding" 
    |> setTime Day
    |> setWeather Clear
    |> face North
    |> stepForward



cursor
|> withBlock "Stone"
|> drawPyramid  10

cursor
|> withBlock "Stone"
|> turret 4 4 15
|> stepUp
|> stepUp
|> withBlock "Oak Wood Plank"
|> drawPyramid 6

    // |> crenelation 4 4 


// sample:
// |> face North
// |> stepForward
// |> withBlock "Stone"
// |> placeBlock
// |> stepForward
// |> placeBlock
// |> turnRight
// |> drawRect 4 4
// // |> resetPosition
// |> ignore


