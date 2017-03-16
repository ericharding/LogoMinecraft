
(* This download script isn't part of the project because it depends on FSharp.Data and I don't want to add that to the minecraft sln *)
#I __SOURCE_DIRECTORY__
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open FSharp.Data
open System.IO
open System.Text.RegularExpressions

let url = "https://www.digminecraft.com/lists/item_id_list_pc.php"
type ItemList = HtmlProvider<"https://www.digminecraft.com/lists/item_id_list_pc.php">
let data = ItemList.Load(url)


let reg = new Regex("(.*) \(minecraft:(.*)\)", RegexOptions.Compiled)

// let names = data.Tables.``Minecraft ID List``.Rows |> Seq.map (fun r -> r.Name)

//printfn "Name, TileName, DataValue, ID"
data.Tables.``Minecraft ID List``.Rows 
    |> Seq.iter (fun row ->
        let groups = (reg.Match row.Name).Groups
        // csv
        //let dv = if row.DataValue.HasValue then string(row.DataValue.Value) else ""
        //printfn "%s, %s, %s, %i" groups.[1].Value groups.[2].Value dv row.ID
        if row.DataValue.HasValue then
            printfn """{ Name="%s"; TileName="%s"; DataTag=Some %i; ID=%i}""" groups.[1].Value groups.[2].Value row.DataValue.Value row.ID
        else
            printfn """{ Name="%s"; TileName="%s"; DataTag=None; ID=%i}""" groups.[1].Value groups.[2].Value row.ID
        )
