module functions

//basic function types inferred
//function add takes two arguments x and y
let add x y = x + y

let sum = add 1 2
printfn "sum = %d" sum

//function with type annotation
let mult (x : int) (y : int) = x * y

let product = mult 2 3
printfn "product = %d" product

(* recursive function
   weird backtick name allows us to make strange function names 
   such as using keywords or spaces! *)
let rec power ``base`` exponent = 
    if exponent = 0 then 
        1
    else 
        ``base`` * (power ``base`` (exponent - 1))

printfn "%d" (power 2 3)


(* currying! You can partially apply a function to get a 
   new function with 'fixed' arguments *)
let add1 y = add 1 y
let add2 = add 2

printfn "%d" (add1 3)
printfn "%d" (add2 3)


(* basic recursive fibonacci *)
let rec fibonacci x =
    if x = 0 then
        1
    elif x = 1 then
        1
    else
        (fibonacci (x-1)) + (fibonacci (x-2))

printfn "%d" (fibonacci 0)
printfn "%d" (fibonacci 1)
printfn "%d" (fibonacci 2)
printfn "%d" (fibonacci 3)
printfn "%d" (fibonacci 4)