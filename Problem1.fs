open System

[<EntryPoint>]
let main argv = 
    let sam1 = List.sum [for i in 1 .. 999 -> List.max [for j in [3;5] -> if i % j = 0 then i else 0]]
    printfn "\n%A" sam1
    Console.ReadKey() |> ignore
    0 // return an integer exit code
