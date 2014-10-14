open System

[<EntryPoint>]
let Problem2 argv = 
    let limit = 4000000
    let testEven n = 
        if n%2=0 then n else 0
    let fib (n, m) = 
        if n < limit then Some (n, (m, n+m)) else None
    let fibSeq =
        Seq.unfold fib (1,1)
    let thingsToSum = List.map testEven (List.ofSeq fibSeq)
    
    printfn "%A" fibSeq
    printfn "%A" thingsToSum
    printfn "%A" (List.sum thingsToSum)

    Console.ReadKey() |> ignore
    0
