module Options

let addOne x = x + 1

let addOne x = 
  if x = None then 0
  else x.Value + 1

let result = addOne (Some 2)

let addOne x = 
  if x = None then None
  else Some(x.Value + 1)

let result = addOne None