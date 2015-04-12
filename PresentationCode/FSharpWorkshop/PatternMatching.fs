
module PatternMatching

let addOne x =
   match x with 
   | None -> None
   | Some n -> Some(n + 1)

//match [something] with 
//| pattern1 -> expression1
//| pattern2 -> expression2
//| pattern3 -> expression3

//match [something] with 
//| lambda-expression-1
//| lambda-expression-2
//| lambda-expression-3

let x = 
    match 1 with 
    | 1 -> "a"
    | 2 -> "b"  
    | _ -> "z" // _ wildcard, similar to default in C#

// all match results must be of the same type
let x = 
    match 1 with 
    | 1 -> 42
    | 2 -> true  // error wrong type
    | _ -> "hello" // error wrong type

let y = 
    match (2, 33) with 
    // binding to a named value
    | (1, x) -> printfn "x=%A" x
    //| (x, y) -> printfn "pattern is not 1,x, it is %d,%d" x y

type Choices = A | B | C | D
let x = 
    match A with 
    | A | B | C -> "a or b or c"
    | D -> "d"

let y = 
    match [1;2;3] with 
    // binding to explicit positions
    // square brackets used!
    | [1;x;y] -> printfn "x=%A y=%A" x y

    // binding to head::tail. 
    // no square brackets used!
    | 1::tail -> printfn "tail=%A" tail 
    
    // empty list
    | [] -> printfn "empty" 

    // list not starting with 1
    | x::tail -> printfn "not starting with 1, starting with x=%A " x

let elementsAreEqual aTuple = 
    match aTuple with 
    | (x,y) -> 
        if (x=y) then printfn "both parts are the same" 
        else printfn "both parts are different" 

let elementsAreEqual aTuple = 
    match aTuple with 
    | (x,y) when x=y -> 
        printfn "both parts are the same" 
    | _ ->
        printfn "both parts are different" 

// pattern matching using regular expressions
open System.Text.RegularExpressions

let classifyString aString = 
    match aString with 
    | x when Regex.Match(x,@".+@.+").Success-> 
        printfn "%s is an email" aString
        
    // otherwise leave alone
    | _ -> 
        printfn "%s is something else" aString


//test
classifyString "alice@example.com"
classifyString "google.com"


open System.Text.RegularExpressions

// create an active pattern to match an email address
let (|EmailAddress|_|) input =
   let m = Regex.Match(input,@".+@.+") 
   if (m.Success) then Some input else None  

// use the active pattern in the match   
let classifyString aString = 
    match aString with 
    | EmailAddress x -> 
        printfn "%s is an email" x
        
    // otherwise leave alone
    | _ -> 
        printfn "%s is something else" aString

//test
classifyString "alice@example.com"
classifyString "google.com"


//"function" keyword
let f aValue = 
    match aValue with 
    | _ -> "something" 

let f = 
    function 
    | _ -> "something" 

// using function keyword
let result = 
        [2..10] |> List.map (function 
        | 2 | 3 | 5 | 7 -> sprintf "prime"
        | _ -> sprintf "not prime"
        )
        
// source: http://fsharpforfunandprofit.com/posts/match-expression/
// License: http://creativecommons.org/licenses/by/3.0/
