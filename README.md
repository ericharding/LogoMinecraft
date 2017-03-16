# LOGOish Minecraft

This lets you draw structures in Minecraft using a "cursor" representing the current location.  The resulting code is intended to be simple enough for new programmers to grasp and be able to edit.

Example:
```f#
let cursor = startAt send "player_name" 
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
```

More complex structures can be built up naturally by building functions from primitives.
```f#
let drawRect depth width =
    drawLine depth 
    >> turnRight 
    >> drawLine width 
    >> turnRight 
    >> drawLine depth 
    >> turnRight 
    >> drawLine width
    >> turnRight 
    
let rec drawPyramid width (c:Cursor) =
    if width > 0 then 
        c 
        |> drawRect width width
        |> stepUp
        |> stepForward
        |> turnRight
        |> stepForward
        |> turnLeft
        |> drawPyramid (width-2)
    
```


To configure a Minecraft server to work with this you have to enable the "rcon" remote console.  There's probably better ways to interact with the Minecraft server but this works well enough.
In the server.properties you need:
enable-rcon=true
rcon.port=25575
rcon.password=secret_password
