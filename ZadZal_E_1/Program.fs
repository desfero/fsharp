// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

let sum list = 
    list 
    |> List.filter (fun e -> e  > 0)
    |> List.sum

[<EntryPoint>]
let main argv =
    let list = [1; -2; 4]

    let result = sum list
 
    printfn "%i" result

    Console.ReadLine() |> ignore
    0 // return an integer exit code
