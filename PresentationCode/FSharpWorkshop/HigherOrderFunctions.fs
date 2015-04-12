module HigherOrderFunctions

let sum a b = a + b

let execute a b op = op a b

let result1 = execute 2 4 sum

let result2 = execute 2 4 (fun a b -> a + b)

let result3 = execute 2 4 (+)

let result4 = execute 2 4 (*)

let result5 = (-) 8 5