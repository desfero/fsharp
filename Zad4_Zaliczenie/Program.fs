// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
let potega x n =
    let mutable result = x
    if n >= 0 then 
       result <- 1
       for i = 1 to n do
         result <- result * x
    else 
        raise (System.ArgumentException("Wartość powinna być większa lub równa zeru"))
    result
        

[<EntryPoint>]
let main argv = 
    System.Console.WriteLine(potega 2 -3)

    Console.ReadLine() |> ignore

    0 // return an integer exit code
