module pattern_matching

type Gender =
    | Male
    | Female

let AnnounceBirth g =
    match g with
    | Male -> printfn "It's a boy!"
    | Female -> printfn "It's a girl!"

AnnounceBirth Male

(* =========================== *)
type Point =
    | TwoDimension of int * int
    | ThreeDimension of int * int * int
    | FourDimension of int * int * int * int

let MoveToPoint p =
    match p with
    | TwoDimension(x,y) -> printfn "You are now at position (%d, %d)" x y
    | ThreeDimension(x,y,z) -> printfn "You are now at position (%d, %d, %d)" x y z
    | _ -> printfn "I don't know how to move in this space!"

MoveToPoint (TwoDimension(2,1))

let pnt = ThreeDimension(1,2,3)
MoveToPoint pnt

let pnt4 = FourDimension(4,3,2,1)
MoveToPoint pnt4

let ThreeDimension(x,y,z) as pnt2 = pnt
printfn "%d" x
printfn "%d" y
printfn "%d" z