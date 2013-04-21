module behavioural_abstraction

(* 'traditional' way to perform operations on all items in a list *)
(* we have a lot of duplicate code but it's algorithmic code not data structural code *)
(* in traditional OO this is not something that is easy to abstract *)
let doubleItems (coll : list<int>) = 
    let mutable resultSet = []
    for i = ((Seq.length coll) - 1) downto 0 do
        resultSet <- (2 * coll.[i]) :: resultSet
    resultSet

let squareItems (coll : list<int>) = 
    let mutable resultSet = []
    for i = ((Seq.length coll) - 1) downto 0 do
        resultSet <- (coll.[i] * coll.[i]) :: resultSet
    resultSet

(* in functional programming this is easy to abstract because we can easily pass *)
(* functions as parameters! *)

let square x = x * x
let double x = 2 * x

let applyToItems func (coll : list<int>) =
    let mutable resultSet = []
    for i = ((Seq.length coll) - 1) downto 0 do
        resultSet <- (func coll.[i]) :: resultSet
    resultSet

let doubledItems = applyToItems double [1..5]
let squaredItems = applyToItems square [1..5]

(* list iteration operations like this are incredibly common and many functional
   languages have a good library for many common patterns *)

let doubledItems2 = List.map double [1..5]
let squaredItems2 = List.map square [1..5]

let squaredThenDoubled = 
    [1..5] 
        |> List.map square
        |> List.map double

let squareAndDouble = square >> double

let squaredThenDoubled2 = List.map squareAndDouble [1..5]