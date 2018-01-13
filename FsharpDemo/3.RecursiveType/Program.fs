
// A small recursive type

type tree =
| Leaf of string
| Node of string * tree * tree

let rec dfs (mytree: tree) = 
    match mytree with
    | Leaf leaf -> printfn "%s" leaf
    | Node(value, left, right) -> 
        dfs left
        dfs right 
        printfn "%s" value

let my_tree = Node( "A", Node("B", Leaf("D"), Leaf("E") ), Node("C" ,Leaf("F"), Leaf("G")) )
dfs (my_tree) 

//      A
//    /   \
//   B     C
//  / \   / \
//  D  E  F  G