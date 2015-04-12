module Tuples

let add (x,y) =
   x + y

add (3,4)

let displayResult result =
   let (quotient, remainder) = result
   printfn "quotient is %d and remainder is %d" quotient remainder 

let displayResult (quotient, remainder) =
   printfn "quotient is %d and remainder is %d" quotient remainder 

let divide dividend divisor = 
   let quotient = dividend / divisor 
   let remainder = dividend % divisor 
   (quotient, remainder)

let result = divide 7 5

displayResult result
