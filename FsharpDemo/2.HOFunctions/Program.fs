// High order functions

// Pattern matching
let rec map f list =
    match list with
    | head :: tail -> f head :: map f tail
    | [] -> [] 

let square x = x*x

let squared_list = map square [1;2;3]

printfn "%A" squared_list 

//////////////////////////////////
let rec filter cond list =
    match list with
    | head :: tail ->  if cond head then head :: filter cond tail 
                       else filter cond tail
    | [] -> [] 

let greater x y = x > y  
let greater2 x = greater x 2 

let squared_condition = map square ( filter greater2 [1;2;3] )
printfn "%A" squared_condition 

let condition_squared = filter greater2 (map square [1;2;3] )
printfn "%A" condition_squared 