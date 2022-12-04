

let cleanCharsToInts (elfChars:string) =
    let split = elfChars.Split '-'
    (int split.[0]), (int split.[1])

let contains (line:string) =
    let lineSplit = line.Split ','
    let firstStart, firstEnd = cleanCharsToInts lineSplit.[0]
    let secondStart, secondEnd = cleanCharsToInts lineSplit.[1]
    match (firstStart <= secondStart && firstEnd >= secondEnd) ||
        (secondStart <= firstStart && secondEnd >= firstEnd) with
        | true -> 1
        | _ -> 0
  
let contains2 (line:string) =
    let lineSplit = line.Split ','
    let firstStart, firstEnd = cleanCharsToInts lineSplit.[0]
    let secondStart, secondEnd = cleanCharsToInts lineSplit.[1]
    match (firstStart <= secondStart && firstEnd >= secondStart) ||
        (secondStart <= firstStart && secondEnd >= firstStart) with
        | true -> 1
        | _ -> 0
    
System.IO.File.ReadLines "4.input.txt"
    |> Seq.map contains2 
    // |> Seq.toArray
    |> Seq.sum


// int 'a', int 'z', int 'A', int 'Z'
