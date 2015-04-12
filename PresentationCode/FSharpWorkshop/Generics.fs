module Generics

// val onAStick : 'a -> string
let onAStick x = x.ToString() + " on a stick"


//val concatString : 'a -> 'b -> string
let concatString x y = x.ToString() + y.ToString()


//val isEqual : 'a -> 'a -> bool
let isEqual x y = (x=y)

