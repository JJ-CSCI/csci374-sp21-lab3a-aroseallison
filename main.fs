module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4

let footToInch x =
    x * 12.00 // write your code here

let yardToFoot v =
    v * 3.00 // write your code here

let mileToYard mile =
   mile * 1760.00// write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    y |> yardToFoot |> footToInch |> inchToMillimeter // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float `
let divBy1000 =
    fun x->x / 1000.00
     // write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    divBy1000(n) // write your code here

let meterToKilometer =
    fun x->x / 1000.00 // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    millimeterToMeter >> meterToKilometer // write your code here

let inchToMeter =
     inchToMillimeter >> millimeterToMeter // write your code here

let yardToKilometer =
    yardToMillimeter >> millimeterToKilometer // write your code here

let mileToMeter =
    mileToYard >> yardToMillimeter >> millimeterToMeter // write your code here


// Define following weight unit transformations
let ounceToGram v =
    v * 28.349523125 // write your code here

let poundToOunce p =
    p * 16.00 // write your code here

let shortTonToPound t =
    t * 2000.00 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    divBy1000(g) // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    gramToKilogram >> divBy1000 // write your code here

let poundToKilogram =
    poundToOunce >> ounceToGram >> gramToKilogram  // write your code here

let shortTonToMetricTon =
    shortTonToPound >> poundToKilogram >> divBy1000  // write your code here
