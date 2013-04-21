module parallel

(* using the community FSharp Powerpack
   to run in fsi you will need to load the assembly
   
   #r "path\\to\\assembly"

   don't forget the escaped backslashes in the path! *)

open Microsoft.FSharp.Collections

let double (x: 'u) = 2 * x
let logger message x =
    printfn "%s: %A" message x
    x

let loggedDoubler = logger "before" >> double >> logger "after"

let doubledList = PSeq.map loggedDoubler [1..100]