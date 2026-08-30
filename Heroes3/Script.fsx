#load "Heroes.fsx"

open Heroes3Models

let rec EquipArtifacts  (artifacts: Artifact list) (count: int) (hero: Hero) : Hero list =
    if count = 0 then
        if Hero.ArtsEquipped hero |> List.length = 4 then
            [hero]
        else
            []
    else
        artifacts
        |> List.filter (Hero.IsEquipped hero >> not)
        |> List.collect (Hero.Equip hero >> EquipArtifacts artifacts (count - 1))

let allCombinations =
    Heroes.Classes.AllClasses
    |> List.collect (EquipArtifacts Heroes.Artifacts.AllArtifacts 4)
    |> List.distinct
    |> List.groupBy(fun h -> h.TotalStats)

// Take first 10 combinations
allCombinations
|> List.sortBy(fun (stats, heroes) -> heroes.Length)
|> List.take 10
|> List.iter(fun (stats, heroes) -> printfn "Stats: %A, Heroes: %d" stats heroes.Length)

// How may different stats are there and how many heroes have each stat combination
allCombinations
|> List.map(fun (stats, heroes) -> stats, heroes.Length)
|> List.sortByDescending(fun (stats, count) -> count)
|> List.groupBy(fun (stats, count) -> count)
|> List.map(fun (count, statsAndCounts) -> count, statsAndCounts.Length)

