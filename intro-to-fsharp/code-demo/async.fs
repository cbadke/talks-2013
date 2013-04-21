module async

open System.Threading

let workThenWait x = 
    async { 
        printfn "start %d" x
        do! Async.Sleep(5000)
        printfn "done! %d" x
    }


let demo() = 
    let timer = new System.Diagnostics.Stopwatch()
    do timer.Start()
    [1..100]
    |> Seq.map workThenWait
    |> Async.Parallel 
    |> Async.RunSynchronously 
    |> ignore
    do timer.Stop()
    printfn "Elapsed Time: %d" timer.ElapsedMilliseconds