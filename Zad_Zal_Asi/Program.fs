// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

let rec create n x =
    match n with
    | 0 -> []
    | _ -> create (n - 1) x @ [x + n - 1]      

[<EntryPoint>]
let main argv = 
    
    printfn "%A" (create 3 5)

    Console.ReadLine() |> ignore

    0 // return an integer exit code
