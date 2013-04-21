module structs

type Person =
    {
        Name: string
        Age: int
    }

let bob = { Name = "Bob Loblaw";  Age = 23 }

printfn "Object = %A" bob
printfn "Name = %s" bob.Name
printfn "Age = %d" bob.Age