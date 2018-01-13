
type PropertyExample(seed) = 
    // private mutable value
    let mutable myProp = seed

    // private function
    let square x = x * x

    // immutable property 
    // using a constructor parameter
    member this.Seed = seed

    // immutable property 
    // using a private function
    member this.SeedSquared = square seed

    // mutable property
    // changing a private mutable value
    member this.MyProp 
        with get() = myProp 
        and set(value) =  myProp <- value

    // mutable property with private set
    member this.MyProp2 
        with get() = myProp 
        and private set(value) =  myProp <- value

    // automatic immutable property (in VS2012)
    member val ReadOnlyAuto = 1

    // automatic mutable property (in VS2012)
    member val ReadWriteAuto = 1 with get,set

// test 
let pe = new PropertyExample(42)
printfn "%i"  pe.Seed
printfn "%i"  pe.SeedSquared
printfn "%i"  pe.MyProp
printfn "%i"  pe.MyProp2

// try calling set
pe.MyProp <- 43    // Ok
printfn "%i" pe.MyProp

// try calling private set
//pe.MyProp2 <- 43   // Error

