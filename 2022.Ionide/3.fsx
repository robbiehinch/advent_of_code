

let scoreIten item= match item with
                            | v when v >= 'a' && v <= 'z' -> (int v) - (int 'a') + 1
                            | v when v >= 'A' && v <= 'Z' -> (int v) - (int 'A') + 26 + 1
                            | _ -> 0


let scoreLine (line:string) =
    let halfLength = line.Length / 2
    let firstHalf = line |> Seq.take halfLength
                                                    |> Set.ofSeq
    let secondHalf = line |> Seq.skip halfLength
                                                    |> Set.ofSeq

    let commonChars = Set.intersect firstHalf secondHalf
    commonChars |> Seq.map scoreIten
                |> Seq.sum

    
let scoreBadges (lines:string[]) =

    let commonChars12 = Set.intersect (lines.[0] |> Set.ofSeq) (lines.[1] |> Set.ofSeq) 
    let commonChars123 = Set.intersect commonChars12 (lines.[2] |> Set.ofSeq) 
    commonChars123 |> Seq.map scoreIten
                |> Seq.sum

    
    
System.IO.File.ReadLines "3.input.txt"
    |> Seq.chunkBySize 3
    |> Seq.map scoreBadges 
    // |> Seq.toArray
    |> Seq.sum


// int 'a', int 'z', int 'A', int 'Z'
