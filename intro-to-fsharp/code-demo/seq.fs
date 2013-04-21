module sequences

(* sequences are like lists but you can define how the elements are generated *)

let firstFiveIntegers = seq {
    for x in [1..5] do
        yield x
}

firstFiveIntegers |> Seq.iter (printfn "%d")

let fibonacci_poor = seq {
    let x1 = ref 1
    let x2 = ref 1
    while true do
        yield x1.Value
        let x3 = x1.Value + x2.Value
        x1 := x2.Value
        x2 := x3
}

let fibonacci = 
    let rec fib a b = seq {
        yield a
        yield! fib b (a+b)
    }
    fib 1 1

fibonacci |> Seq.take 5 |> Seq.iter (printfn"%d")