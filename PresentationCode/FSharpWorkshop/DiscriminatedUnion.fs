module DiscriminatedUnion

type Shape =
| Circle of decimal
| Square of decimal
| Rectangle of decimal * decimal

let pi = 3.14M

let area = function
    | Circle radius -> pi * radius * radius
    | Square s -> s * s
    | Rectangle (h, w) -> h * w

let radius = 15.0M
printfn "Area of circle that has radius %f: %f" radius (area (Circle radius))

let squareSide = 10.0M
printfn "Area of square that has side %f: %f" squareSide (area (Square(squareSide)))

let height, width = 5.0M, 10.0M
printfn "Area of rectangle that has height %f and width %f is %f" height width (area (Rectangle(height, width)))


type tree =
    | Leaf of int
    | Node of tree  * tree
 
let simpleTree =
    Node (
      Leaf 1,
      Node (
        Leaf 2,
        Node (
          Node (
            Leaf 4,
            Leaf 5),
          Leaf 3
        )
      )
    )
 
let countLeaves tree =
    let rec loop sum = function
        | Leaf(_) -> sum + 1
        | Node(tree1, tree2) ->
            sum + (loop 0 tree1) + (loop 0 tree2)
    loop 0 tree

printfn "countLeaves simpleTree: %i" (countLeaves simpleTree)

// source: http://en.wikibooks.org/wiki/F_Sharp_Programming/Discriminated_Unions
// license: http://creativecommons.org/licenses/by-sa/3.0/