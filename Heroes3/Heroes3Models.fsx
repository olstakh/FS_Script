type ArtifactType =
    | Helm
    | Armor
    | Weapon
    | Shield
    | Cape
    | Feet
    | Ring
    | Necklace
    with
        static member FromString (s: string) =
            match s with
            | "H" -> Helm
            | "A" -> Armor
            | "W" -> Weapon
            | "S" -> Shield
            | "C" -> Cape
            | "F" -> Feet
            | "R" -> Ring
            | "N" -> Necklace
            | _ -> failwithf "Unknown artifact type: %s" s

type Stats =
    {
        Attack: int
        Defense: int
        SpellPower: int
        Knowledge: int
    } with
        static member (+) (s1: Stats, s2: Stats) =
            {
                Attack = s1.Attack + s2.Attack
                Defense = s1.Defense + s2.Defense
                SpellPower = s1.SpellPower + s2.SpellPower
                Knowledge = s1.Knowledge + s2.Knowledge
            }
        static member Zero =
            {
                Attack = 0
                Defense = 0
                SpellPower = 0
                Knowledge = 0
            }
        static member Create (attack: int, defense: int, spellPower: int, knowledge: int) =
            {
                Attack = attack
                Defense = defense
                SpellPower = spellPower
                Knowledge = knowledge
            }

type Artifact = {
    Name: string
    Type: ArtifactType
    Bonuses: Stats
}

type Hero = {
    Name: string
    BaseStats: Stats
    Helm: Artifact option
    Armor: Artifact option
    Weapon: Artifact option
    Shield: Artifact option
    Cape: Artifact option
    Feet: Artifact option
    Ring1: Artifact option
    Ring2: Artifact option
    Necklace: Artifact option
} with
    static member Create (name: string, baseStats: Stats) =
        {
            Name = name
            BaseStats = baseStats
            Helm = None
            Armor = None
            Weapon = None
            Shield = None
            Cape = None
            Feet = None
            Ring1 = None
            Ring2 = None
            Necklace = None
        }
    member x.TotalStats =
        [ x.Helm; x.Armor; x.Weapon; x.Shield; x.Cape; x.Feet; x.Ring1; x.Ring2; x.Necklace ]
        |> List.choose id
        |> List.map (fun a -> a.Bonuses)
        |> List.fold (+) x.BaseStats

    static member Equip (x: Hero) (artifact: Artifact) =
        match artifact.Type with
        | Helm -> { x with Helm = Some artifact }
        | Armor -> { x with Armor = Some artifact }
        | Weapon -> { x with Weapon = Some artifact }
        | Shield -> { x with Shield = Some artifact }
        | Cape -> { x with Cape = Some artifact }
        | Feet -> { x with Feet = Some artifact }
        | Ring when x.Ring1.IsNone -> { x with Ring1 = Some artifact }
        | Ring -> { x with Ring2 = Some artifact }
        | Necklace -> { x with Necklace = Some artifact }

    static member IsEquipped (x: Hero) (artifact: Artifact) =
        match artifact.Type with
        | Helm -> x.Helm = Some artifact
        | Armor -> x.Armor = Some artifact
        | Weapon -> x.Weapon = Some artifact
        | Shield -> x.Shield = Some artifact
        | Cape -> x.Cape = Some artifact
        | Feet -> x.Feet = Some artifact
        | Ring -> x.Ring1 = Some artifact || x.Ring2 = Some artifact
        | Necklace -> x.Necklace = Some artifact

    static member ArtsEquipped (x: Hero) : Artifact list =
        [ x.Helm; x.Armor; x.Weapon; x.Shield; x.Cape; x.Feet; x.Ring1; x.Ring2; x.Necklace ]
        |> List.choose id
