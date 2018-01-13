
[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let mutable x = 1
    x <- x + 1
    printfn "%i" x

    0 // return an integer exit code
