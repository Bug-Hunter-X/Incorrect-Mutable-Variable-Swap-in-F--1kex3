let x = 10
let y = 20

let swap x y =
    (y, x) //Return a tuple containing swapped values

let (x, y) = swap x y //Deconstruct the tuple to update x and y
printfn "%d %d" x y //correct result