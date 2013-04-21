module classes

type Animal (name) =
    member this.Name = name
    member this.Eat food = printfn "nom nom %s" food

type Dog (name) =
    inherit Animal(name)
    member this.Bark = printfn "WOOF!"

let animal = new Animal("Fluffy")
animal.Eat "bacon"


let dog = new Dog("Sparky")
dog.Eat "kibble"
dog.Bark