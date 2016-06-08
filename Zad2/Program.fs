
// Napisz funkcję w języku F# sumującą liczby znajdujące się w liście będącej
// parametrem tej funkcji (typ funkcji: float list -> float).

open System

// Antypattern w F#
let sumList list =
    let mutable result = 0
    for i in list do
        result <- result + i
    result 

// Wersja rekurancyjna
let rec sumListRec list =
    match list with
    | [] -> 0
    | head :: tail -> head + sumListRec(tail)

[<EntryPoint>]
let main argv = 

    let list = [1; 2; 3]
    let result = sumListRec list

    Console.WriteLine("There result are " + result.ToString())

    Console.ReadLine() |> ignore

    0 // return an integer exit code
