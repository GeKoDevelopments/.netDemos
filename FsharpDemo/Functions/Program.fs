// Simple function definitions
let f1 x = x + 1
// let f1 (x : int) = x + 1
let f1_result = f1 1
printfn "%i" f1_result

let f2 x y = x + y
let f2_result = f2 1 3
printfn "%i" f2_result

let result = f2 (f1 4) (f1 5)
printfn "%i" result

// Function composition
let square x = x * x
let double x = 2 * x

let squaredouble = double >> square
let squaredouble_result = squaredouble 2
printfn "%i" squaredouble_result

let doublesquare = square >> double 
let doublesquare_result = doublesquare 2
printfn "%i" doublesquare_result

// Function piping
let pipe_squaredouble = 2 |> double |> square
printfn "%i" pipe_squaredouble
// let x = square (double 2)

let doublesquare_pipe = 2 |> square |> double 
printfn "%i" doublesquare_pipe