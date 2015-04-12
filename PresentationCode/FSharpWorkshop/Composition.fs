module Composition

let add4 a = a + 4
let add5 a = a + 5
let add9 = add4 >> add5

let result = add9 1