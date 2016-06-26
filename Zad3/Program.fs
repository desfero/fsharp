// Napisz funkcje w języku F#, zwracająca różne wartości z dwóch list

open System

let rec mem list x = 
  match list with
  | [] -> false
  | head :: tail -> 
    if x = head then true else mem tail x 

let rec intersection list1 list2 = 
  match list1 with
  | head :: tail -> 
      let rest = intersection tail list2
      if mem list2 head then head::rest
      else rest
  | [] -> []

[<EntryPoint>]
let main argv = 
    
    let result = intersection [2; 4; 5; 6] [1; 2; 5; 7]

    Console.WriteLine(result.ToString())

    Console.ReadLine() |> ignore

    0 // return an integer exit code
