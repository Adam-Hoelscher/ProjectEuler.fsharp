open System

[<EntryPoint>]
let main argv = 
    let target = 60085//1475143L
    let findFactors x = seq{ 
        for y in 1..x do
            if x%y = 0 then yield y
            }
    let isPrime x =
        let y = findFactors x
        Seq.length y = 2
    let primeFactors x = seq{
        for y in (findFactors x) do
            if (isPrime y) then yield y
            }
    let LPF x =
        Seq.max (primeFactors x)
//    printf "%A" (LPF target)
    printf "%A" (findFactors target)
    Console.ReadKey() |> ignore
    0 // return an integer exit code
