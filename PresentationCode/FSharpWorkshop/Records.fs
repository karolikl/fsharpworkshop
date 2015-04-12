module Records

type DivisionResult = 
   { 
   Quotient: int; 
   Remainder: int 
   }
   
let result = { Quotient = 3; Remainder = 1 }
let result = { Quotient = 3 }
let newResult = { Quotient = result.Quotient; Remainder = 0 }
let newResult = { result with Remainder = 0 }

let result1 = { Quotient = 3; Remainder = 1 } 
let result2 = { Quotient = 3; Remainder = 1 } 
result1 = result2 