module Pipelining

let numbers = [1;7;6;4;6;1;8;2]
let filterednumbers1 = List.filter (fun n -> n > 1) numbers

let filterednumbers2 = numbers |> List.filter (fun n -> n > 1)

let filterednumbers3 = numbers 
                       |> List.filter (fun n -> n > 1)
                       |> List.filter (fun n -> n < 7)
