module Minecraft

type Block = 
    { Name : string
      TileName : string
      DataValue : int
      DataTag : int option
      ID : int }


type ExistingBlockHandling = Replace | Keep | Destroy

type Heading =
    | North
    | South
    | East
    | West
    with 
        member x.Right() = 
            match x with
            | North -> East
            | East -> South
            | South -> West
            | West -> North
        member x.Left() = 
            match x with
            | North -> West
            | East -> North
            | South -> East
            | West -> South

type Direction = Left | Right    

type Position = int * int * int

type Time =
    | Day
    | Night
    | Dusk
    | Dawn

type Weather =
    | Clear
    | Rain
    | Thunder

type Cursor = {
    send : string->int
    player_target: string
    facing : Heading
    block_handling : ExistingBlockHandling
    block : Block option
    position: Position
}
    with
        member x.Send s = x.send s |> ignore; x

let private initialCursor : Cursor = {
    send = (fun s -> 0)
    player_target = ""
    facing = North
    block_handling = Replace
    block = None
    position = 0,0,0
}



//
// Private helpers

let private loadBlocks path =
    System.IO.File.ReadAllLines path |> Seq.skip 1 |> Seq.map (fun line ->
        let parts = line.Split(',')
        { Name = parts.[0]
          TileName = parts.[1].Trim()
          DataValue = match System.Int32.TryParse (parts.[2]) with true,x -> x | false,_ -> 0
          DataTag = None
          ID = 0
        })

let private blockMap (blocks : Block seq) =
    blocks |> Seq.map (fun b -> b.Name.ToLower(), Some b) |> Map.ofSeq

let private withBlockImpl map (name:string) (c:Cursor) =
    match Map.tryFind (name.ToLower()) map with
    | Some b -> { c with block = b}
    | None -> c

let private allBlocks () = loadBlocks "Blocks.csv" |> blockMap

let private handleToStr = function
    | Replace -> "replace"
    | Keep -> "keep"
    | Destroy -> "destroy"
let private blockToStr (block: Block) oldhandling =
    let oldv = handleToStr oldhandling
    match block.DataTag with
    | Some dt -> sprintf "%s %i %s %i" block.TileName block.DataValue oldv dt
    | None -> sprintf "%s %i %s" block.TileName block.DataValue oldv

let (+++) (a,b,c) (x,y,z) = (a+x),(b+y),(c+z)
let sleep (i:int) = System.Threading.Thread.Sleep i

/////////////////////////////////////////////////////////////////////
// Methods
/////////////////////////////////////////////////////////////////////

let startAt send name =
    { initialCursor with send = send; player_target = name}

let silent (c:Cursor) =
    c.Send "gamerule commandBlockOutput false"

let withBlock = withBlockImpl (allBlocks())

let face dir c = {c with facing = dir}

let delta direction distance =
    match direction with
    | North -> 0,0,-distance
    | South -> 0,0,distance
    | East -> distance,0,0
    | West -> -distance,0,0

let delta3 direction depth width height =
    match direction with
    | North -> width,height,-depth
    | South -> -width,height,depth
    | East -> depth,height,width
    | West -> -depth,height,-width

let delta2 direction ahead right =
    delta3 direction ahead right 0

let addDelta direction distance pos =
    pos +++ (delta direction distance)
    
let move direction distance c = 
    let x,y,z = c.position
    { c with position = addDelta direction distance c.position}

let stepForward c = 
    move c.facing 1 c



let moveUp distance c =
    let x,y,z = c.position
    { c with position = x,y+distance,z}
let moveDown distance = moveUp -distance

let moveForward distance c =
    move c.facing distance c

let moveBack distance c =
    move c.facing (-distance) c

let stepBack = moveBack 1



let stepUp = moveUp 1
let stepDown = moveDown 1

let turnRight c =
    { c with facing = c.facing.Right()}

let turnLeft c =
    { c with facing = c.facing.Left() }

let stepLeft c =
    c |> turnLeft |> stepForward |> turnRight

let stepRight c =
    c |> turnRight |> stepForward |> turnLeft

let placeBlock c =
    let x,y,z = c.position
    match c.block with
    | Some block -> 
        let cmd = sprintf "execute %s ~ ~ ~ setblock ~%i ~%i ~%i %s" c.player_target x y z (blockToStr block c.block_handling)
        c.Send cmd
    | None -> c.Send "say No block selected"

let fillTo x y z (c:Cursor)=
    let xa,ya,za = c.position
    let xb,yb,zb = (xa+x), (ya+y), (za+z)
    match c.block with
    | None -> ()
    | Some block ->
        c.Send (sprintf "execute %s ~ ~ ~ fill ~%i ~%i ~%i ~%i ~%i ~%i %s" c.player_target xa ya za xb yb zb (blockToStr block c.block_handling)) |> ignore
    { c with position = xb,yb,zb}

let setTime time (c:Cursor) =
    let timestr = 
        match time with
        | Day -> "day"
        | Night -> "night"
        | Dusk -> "12000"
        | Dawn -> "0"
    c.Send (sprintf "time set %s" timestr)

let setWeather weather (c:Cursor) =
    let weatherstr =
        match weather with
        | Clear -> "clear"
        | Rain -> "rain"
        | Thunder -> "thunder"
    c.Send (sprintf "weather %s" weatherstr)

let resetPosition c = { c with position = 0,0,0}

//
// Get fancier

let drawLineSlow dist (c:Cursor) =
    Seq.fold (fun c _ -> c |> placeBlock |> stepForward) c [1..dist]

let drawLine dist (c:Cursor) =
    let x',y',z' = delta c.facing dist
    printfn "target: %A" (x',y',z')
    fillTo x' y' z' c
    
let drawRect depth width =
    drawLine depth 
    >> turnRight 
    >> drawLine width 
    >> turnRight 
    >> drawLine depth 
    >> turnRight 
    >> drawLine width
    >> turnRight 

let fillRect depth width (c:Cursor) =
    let x,y,z = delta2 c.facing depth width
    fillTo x y z c

let fillRect3 depth width height (c:Cursor) =
    let x,y,z = delta3 c.facing depth width height
    fillTo x y z c
        
let rec drawPyramid width (c:Cursor) =
    if width > 0 then 
        drawRect width width c
        |> stepUp
        |> stepForward
        |> turnRight
        |> stepForward
        |> turnLeft
        |> drawPyramid (width-2)

let rec fillPyramid width (c:Cursor) =        
    if width > 0 then
        c |> fillRect width width |> ignore
        c |> stepUp |> stepForward |> turnRight |> stepForward |> turnLeft
        |> fillPyramid (width-2)

let rec filledPyramid inblock edgeblock width (c:Cursor) =
    withBlock inblock c |> fillPyramid width
    withBlock edgeblock c |> drawPyramid width

let rec repeat count fn c =
    if count > 0 then
        fn c |> repeat (count-1) fn
    else
        c
