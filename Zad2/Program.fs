
// Napisz funkcję w języku F# sumującą liczby znajdujące się w liście będącej
// parametrem tej funkcji (typ funkcji: float list -> float).

open System

let sumList list =
    let mutable result = 0
    for i in list do
        result <- result + i
    result 

[<EntryPoint>]
let main argv = 

    let list = [1; 2; 3]
    let result = sumList list

    Console.WriteLine("There result are " + result.ToString())

    Console.ReadLine() |> ignore

    0 // return an integer exit code
