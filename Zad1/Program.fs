
// Zrealizuj w języku F# funkcję typu char * string -> int zliczającą liczbę
// wystąpień podanego znaku w łańcuchu tekstowym

open System

let countChar (character : char) (str : string) = 
    let mutable count = 0
    for ch in str do
        if ch = character
            then count <- count + 1
    count


[<EntryPoint>]
let main argv = 
    let char = 'r'
    let world = "Programming"
    let result = countChar char world

    Console.WriteLine("There are " + result.ToString() + " occurrence of " + char.ToString() + " in the " + world + ".")

    Console.ReadLine() |> ignore

    0 // return an integer exit code
