// Create a 2D array with 2 rows and 3 columns.
let (arr : int [,]) = Array2D.init 2 3 (fun x y -> 3 * x + y + 1)

printfn "%A" arr


/// <summary>Transposes the elements in a 2D array.</summary>
/// <param name = "arr">A 2D array.</param>
/// <returns>A transposed array of the input array.</returns>
// Transpose the array arr from 2 row and 3 columns to 3 rows and 2 columns.
let transposeArr (arr : 'a [,]) : 'a [,] =
    let tmpArr = Array2D.init (Array2D.length2 arr) (Array2D.length1 arr)
                    (fun x y -> arr.[y,x])
    tmpArr


printfn "%A" (transposeArr arr)



// Performing a white-box test on the transposeArr function is pointless.
// The function does not have any branches with conditions, and thus,
// there is no conditions/branches to test.