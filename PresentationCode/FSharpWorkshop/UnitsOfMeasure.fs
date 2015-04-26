module UnitsOfMeasure

// It's about 13 kilometeres from home to work
let distanceToWork = 13

//It's about 2 norwegian mil from home to NN HQ
let distanceToHq = 2 

//Calculate distance from work to HQ
let distanceFromWorkToHq = distanceToHq - distanceToWork

[<Measure>] type mil
[<Measure>] type km
let distanceToWork = 13<km>
let distanceToHq = 2<mil> 
let distanceFromWorkToHq = distanceToHq - distanceToWork
