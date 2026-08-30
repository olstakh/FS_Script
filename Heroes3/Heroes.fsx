#load "Heroes3Models.fsx"
open Heroes3Models

module Classes =
    let AllClasses =
        [
            Hero.Create("Рыцарь",   { Attack = 2; Defense = 2; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Священник", { Attack = 1; Defense = 0; SpellPower = 2; Knowledge = 2 })
            Hero.Create("Рейнджер", { Attack = 1; Defense = 3; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Друид", { Attack = 0; Defense = 2; SpellPower = 1; Knowledge = 2 })
            Hero.Create("Алхимик", { Attack = 1; Defense = 1; SpellPower = 2; Knowledge = 2 })
            Hero.Create("Волшебник", { Attack = 0; Defense = 0; SpellPower = 2; Knowledge = 3 })
            Hero.Create("Одержимий", { Attack = 2; Defense = 2; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Еретик", { Attack = 2; Defense = 2; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Рыцарь смерти", { Attack = 1; Defense = 2; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Некромант", { Attack = 1; Defense = 0; SpellPower = 2; Knowledge = 2 })
            Hero.Create("Лорд", { Attack = 2; Defense = 2; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Чернокнижник", { Attack = 0; Defense = 0; SpellPower = 3; Knowledge = 2 })
            Hero.Create("Варвар", { Attack = 4; Defense = 0; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Боевой маг", { Attack = 2; Defense = 1; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Повелитель зверей", { Attack = 0; Defense = 4; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Ведьма", { Attack = 0; Defense = 1; SpellPower = 2; Knowledge = 2 })
            Hero.Create("Воитель стихий", { Attack = 3; Defense = 1; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Элементалист", { Attack = 0; Defense = 0; SpellPower = 3; Knowledge = 3 })
            Hero.Create("Капитан", { Attack = 3; Defense = 0; SpellPower = 2; Knowledge = 1 })
            Hero.Create("Навигатор", { Attack = 2; Defense = 0; SpellPower = 1; Knowledge = 2 })
            Hero.Create("Наёмник", { Attack = 3; Defense = 1; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Изобретатель", { Attack = 0; Defense = 1; SpellPower = 2; Knowledge = 2 })
            Hero.Create("Вождь", { Attack = 0; Defense = 4; SpellPower = 1; Knowledge = 1 })
            Hero.Create("Старейшина", { Attack = 0; Defense = 1; SpellPower = 1; Knowledge = 3 })
        ]

module Artifacts =
    let SimpleWeapons =
        [
            { Type = Weapon; Name = "Секира Кентавра";             Bonuses = Stats.Create(2, 0, 0, 0) }
            { Type = Weapon; Name = "Клинок мёртвого рыцаря";      Bonuses = Stats.Create(3, 0, 0, 0) }
            { Type = Weapon; Name = "Кистень великого гнолла";     Bonuses = Stats.Create(4, 0, 0, 0) }
            { Type = Weapon; Name = "Дубина свирепого огра";       Bonuses = Stats.Create(5, 0, 0, 0) }
            { Type = Weapon; Name = "Меч пылающей преисподней";    Bonuses = Stats.Create(6, 0, 0, 0) }
            { Type = Weapon; Name = "Трезубец могущества";         Bonuses = Stats.Create(7, 0, 0, 0) }
            { Type = Weapon; Name = "Гладиус титана";              Bonuses = Stats.Create(12, -3, 0, 0) }
        ]
    let SimpleShields =
        [
            { Type = Shield; Name = "Щит владыки гномов";          Bonuses = Stats.Create(0, 2, 0, 0) }
            { Type = Shield; Name = "Щит тоскующих мертвецов ";    Bonuses = Stats.Create(0, 3, 0, 0) }
            { Type = Shield; Name = "Щит короля гноллов";          Bonuses = Stats.Create(0, 4, 0, 0) }
            { Type = Shield; Name = "Щит яростного огра";          Bonuses = Stats.Create(0, 5, 0, 0) }
            { Type = Shield; Name = "Щит проклятых";               Bonuses = Stats.Create(0, 6, 0, 0) }
            { Type = Shield; Name = "Щит морской славы";           Bonuses = Stats.Create(0, 7, 0, 0) }
            { Type = Shield; Name = "Щит часового";                Bonuses = Stats.Create(-3, 12, 0, 0) }
        ]
    let SimpleHelms =
        [
            { Type = Helm; Name = "Шлем белого единорога";         Bonuses = Stats.Create(0, 0, 0, 1) }
            { Type = Helm; Name = "Шлем-череп";                    Bonuses = Stats.Create(0, 0, 0, 2) }
            { Type = Helm; Name = "Шлем хаоса";                    Bonuses = Stats.Create(0, 0, 0, 3) }
            { Type = Helm; Name = "Корона великого колдуна";       Bonuses = Stats.Create(0, 0, 0, 4) }
            { Type = Helm; Name = "Шлем бушующего пекла";          Bonuses = Stats.Create(0, 0, 0, 5) }
            { Type = Helm; Name = "Корона пяти морей";             Bonuses = Stats.Create(0, 0, 0, 6) }
            { Type = Helm; Name = "Шлем небесного грома";          Bonuses = Stats.Create(0, 0, -2, 10) }
        ]
    let SimpleArmors =
        [
            { Type = Armor; Name = "Доспех из окаменелого дерева"; Bonuses = Stats.Create(0, 0, 1, 0) }
            { Type = Armor; Name = "Рёбра";                        Bonuses = Stats.Create(0, 0, 2, 0) }
            { Type = Armor; Name = "Чешуйчатый доспех василиска";  Bonuses = Stats.Create(0, 0, 3, 0) }
            { Type = Armor; Name = "Кираса короля циклопов";       Bonuses = Stats.Create(0, 0, 4, 0) }
            { Type = Armor; Name = "Нагрудник из огненной серы";   Bonuses = Stats.Create(0, 0, 5, 0) }
            { Type = Armor; Name = "Королевские доспехи никсов";   Bonuses = Stats.Create(0, 0, 6, 0) }
            { Type = Armor; Name = "Латы титана";                  Bonuses = Stats.Create(0, 0, 10, -2) }
        ]
    let AngelSet =
        [
            { Type = Armor;     Name = "Доспехи чудес";                    Bonuses = Stats.Create(1, 1, 1, 1) }
            { Type = Feet;      Name = "Сандалии святого ";                Bonuses = Stats.Create(2, 2, 2, 2) }
            { Type = Necklace;  Name = "Ожерелье небесной благодати";      Bonuses = Stats.Create(3, 3, 3, 3) }
            { Type = Shield;    Name = "Щит львиной храбрости";            Bonuses = Stats.Create(4, 4, 4, 4) }
            { Type = Weapon;    Name = "Меч правосудия";                   Bonuses = Stats.Create(5, 5, 5, 5) }
            { Type = Helm;      Name = "Шлем божественного просветления";  Bonuses = Stats.Create(6, 6, 6, 6) }
        ]

    let DragonSet =
        [
            { Type = Ring;      Name = "Неподвижный глаз дракона";         Bonuses = Stats.Create(1, 1, 0, 0) }
            { Type = Weapon;    Name = "Языки пламени красного дракона";   Bonuses = Stats.Create(2, 2, 0, 0) }
            { Type = Shield;    Name = "Щит из чешуи дракона";             Bonuses = Stats.Create(3, 3, 0, 0) }
            { Type = Feet;      Name = "Наголенники из драконьей кости";   Bonuses = Stats.Create(0, 0, 1, 1) }
            { Type = Cape;      Name = "Плащ из драконьих крыльев";        Bonuses = Stats.Create(0, 0, 2, 2) }
            { Type = Necklace;  Name = "Ожерелье из зубов дракона";        Bonuses = Stats.Create(0, 0, 3, 3) }      
            { Type = Helm;      Name = "Корона из зубов дракона";          Bonuses = Stats.Create(0, 0, 4, 4) }
        ]

    let AllArtifacts =
        [
            yield! SimpleWeapons
            yield! SimpleShields
            yield! SimpleHelms
            yield! SimpleArmors
            yield! AngelSet
            yield! DragonSet
        ]
