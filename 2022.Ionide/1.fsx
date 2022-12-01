
    

let lines = System.IO.File.ReadAllText "1.input.txt";;

let linesPerElf = lines.Split "\n\n";;

let maxCaloriesPerElf = linesPerElf
                                    |> Seq.map (fun lines -> lines.Split "\n"
                                                                        |> Seq.map (fun line -> match System.Int32.TryParse line with
                                                                                                            | true,int -> int
                                                                                                            | _ -> 0)
                                                                                                |> Seq.sum)
                                    |> Seq.toArray

printfn "%d" (maxCaloriesPerElf |> Seq.sortDescending |> Seq.take 3 |> Seq.sum)

    