module Generics

// val onAStick : 'a -> string
let onAStick x = x.ToString() + " on a stick"

//onAStick "apple"
//onAStick 10
//onAStick true

//val concatString : 'a -> 'b -> string
let concatString x y = x.ToString() + y.ToString()

//let concat = concatString "olav" 20

//val isEqual : 'a -> 'a -> bool
let isEqual x y = (x=y)

//let equalTest = isEqual "olav" 20

