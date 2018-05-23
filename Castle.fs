module Minecraft.Castle
open Minecraft

// create a wall distance,height. End at the base of the far end of the wall
let wall distance height cursor = 
    for x in 1..height do
        cursor
        |> moveUp (x-1)
        |> drawLine distance
        |> ignore
    cursor |> moveForward distance


let crenelation width depth cursor =
    cursor
    |> drawRect width depth
    |> stepUp
    |> repeat 2 
        (repeat (width/2) (placeBlock >> stepForward >> stepForward )
        >> turnRight
        >> repeat (depth/2) (placeBlock >> stepForward >> stepForward )
        >> turnRight)


let turret width depth height cursor =
    cursor 
    |> wall width height
    |> turnRight
    |> wall depth height
    |> turnRight
    |> wall width height
    |> turnRight
    |> wall depth height
    |> turnRight
    // walls done position and draw crenelation
    |> moveUp height
    |> stepBack
    |> stepLeft
    |> crenelation (width+2) (depth+2)

