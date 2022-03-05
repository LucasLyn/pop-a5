// Define a list of lists
let llst = [[1; 2; 3; 4]; [5; 6; 7; 8]; [9; 10; 11; 12]]


/// <summary> Checks if our list is a valid matrix. </summary>
/// <param name = "llst"> A list of lists. </param>
/// <returns> true/false. </returns>
// Check if a list of lists are a valid table;
// 1. The list aren't empty, and;
// 2. All sublists has the same length.
let isTable (llst : 'a list list) : bool =
    let llstHeadLength = llst.Head.Length
    let mutable truthState = true
    for row in llst do
        if row = [] || llstHeadLength <> row.Length then truthState <- false
    truthState
printfn "llst is a table: %A" (isTable llst)



/// <summary> Returns and prints the first element in each list. </summary>
/// <param name = "llst"> A list of lists. </param>
/// <returns> The first element of each sub-list. </returns>
// Returns the Head-value of the lists in llst, if it isn't empty.
let firstColumn (llst : 'a list list) : 'a list =
    let row1 = llst.Item 0
    let row2 = llst.Item 1
    if (isTable llst) then List.map (fun (x : 'a list) -> x.Head) llst
    else
        []
printfn "The first column of llst is: %A" (firstColumn llst)



/// <summary> Removes the first element of each sub-list. </summary>
/// <param name = "llst"> A list of lists. </param>
/// <returns> The list without the first element of each sub-list. </returns>
// Removes the first element in each sublist, if they aren't empty.
let dropFirstColumn (llst : 'a list list) : 'a list list =
    if (isTable llst) then
        List.map (fun (x : 'a list) -> x.Tail) llst
    else
        []
printfn "Removed the first column of llst: %A" (dropFirstColumn llst)



/// <summary> Transposes a list of lists. </summary>
/// <param name = "llst"> A list of lists. </param>
/// <returns> A transposed list of lists. </returns>
// Transpoase a list of lists
let transposeLstLst (llst : 'a list list) : 'a list list=
    let mutable (tmpList : 'a list list) = llst
    let mutable (retList : 'a list list) = [[]]
    let row1Len = (llst.Item 0).Length
    
    if (isTable llst) then
        for i = 0 to (llst.Head.Length - 1) do
            retList <- retList@[firstColumn tmpList]
            tmpList <- (dropFirstColumn tmpList)
        retList
    else llst
printfn "The list is as follows after transposing: %A" (transposeLstLst llst)




// Begin white-box test of functions;
printfn ""
printfn ""
printfn ""
printfn "White-box test;"
printfn "Unit        | Branch | Condition       | Input      | Expected output"
printfn "_____________________________________________________________________"
printfn "isTable     | 1      | row = [] or ... |            |                "
printfn "            | 1a     | True            |[[1; 2]; []]| False          "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (isTable [[1; 2]; []])
            ((isTable [[1; 2]; []]) = false)

printfn ""
printfn "_____________________________________________________________________"
printfn "            | 1b     | False          | [[1]; [2]]  | True           "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (isTable [[1]; [2]])
            ((isTable [[1]; [2]]) = true)

// End of branch 1 tests.


printfn ""
printfn ""
printfn "_____________________________________________________________________"
printfn "firstColumn | 2      | isTable = true  |            |                "
printfn "            | 2a     | True            | [[1]; [2]] | [1; 2]         "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (firstColumn [[1]; [2]])
            ((firstColumn [[1]; [2]]) = [1; 2])

printfn ""
printfn "_____________________________________________________________________"
printfn "            | 2b     | False          |[[1; 2]; []]| []              "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (firstColumn [[1; 2]; []])
            ((firstColumn [[1; 2]; []]) = [])

// End of branch 2 tests.


printfn ""
printfn ""
printfn "_____________________________________________________________________"
printfn "dropFirstColumn | 3      | isTable = true  |            |            "
printfn "                | 3a     | True            | [[1; 2]]   | [2]        "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (dropFirstColumn [[1; 2]])
            ((dropFirstColumn [[1; 2]]) = [[2]])

printfn ""
printfn "_____________________________________________________________________"
printfn "                | 3b     | False          |[[1; 2]; []]| []              "
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (dropFirstColumn [[1; 2]; []])
            ((dropFirstColumn [[1; 2]; []]) = [])

// End of branch 3 tests.


printfn ""
printfn ""
printfn "_____________________________________________________________________"
printfn "transposeLstLst | 4      | isTable = true  |            |            "
printf "                | 4a     | True            | [[1; 2]; "
printf "[3; 4]] | [[]; [1; 3]; [2; 4]] \n"
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (transposeLstLst
            [[1; 2]; [3; 4]]) ((transposeLstLst [[1; 2]; [3; 4]]) =
            [[]; [1; 3]; [2; 4]])

printfn ""
printfn "_____________________________________________________________________"
printfn "                | 4b     | False          |[[1; 2]; []]| [[1; 2]; []]"
printfn "_____________________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (transposeLstLst [[1; 2]; []])
            ((transposeLstLst [[1; 2]; []]) = [[1; 2]; []])

// End of branch 4 tests.

// After the white-box test, all of the expected outputs were met and
// the results have all returned true. With this, we have concluded that
// our white-box test was successful.

// End of white-box test.