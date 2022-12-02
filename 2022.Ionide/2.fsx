

let scoreLine (line:string) =
    let opponent = (int (line.[0])) - (int 'A') + 1
    let mine = (int (line.[2])) - (int 'X') + 1
    match mine - opponent with
    | 0 -> mine + 3
    | x -> match x with
        | 1 -> mine + 6
        | -2 -> mine + 6
        | _ -> mine
    
    
let scoreLinePart2 (line:string) =
    let opponent = (int (line.[0])) - (int 'A') + 1
    match line.[2] with
    | 'Y' -> opponent + 3
    | 'X' -> match opponent with
                | 1 -> 3
                | _ -> opponent - 1
    | 'Z' -> match opponent with
                | 3 -> 1 + 6
                | _ -> opponent + 1 + 6
    
    
let maxCaloriesPerElf = System.IO.File.ReadLines "2.input.txt"
                                    |> Seq.map scoreLinePart2 
                                    // |> Seq.toArray
                                    |> Seq.sum


