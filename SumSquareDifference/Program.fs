// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let sqr x = x * x

let sumOfSquares nums =
    nums
    |> Seq.map sqr
    |> Seq.sum

let squareOfSum nums =
    nums
    |> Seq.sum
    |> sqr
    
let sumSquareDifference nums =
    (nums |> squareOfSum) - (nums |> sumOfSquares)
    
[<EntryPoint>]
let main argv =    
    printfn "%A" ([1..100] |> sumSquareDifference)
    0 // return an integer exit code