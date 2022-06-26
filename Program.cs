Hero william = new Hero("William Wallace", 145);
Hero rodrigo = new Hero("Rodrigo Diaz De Vivar", 155);
Hero george = new Hero("Saint George", 140);

Weapon katana = new Weapon("Katana", 85);
Weapon falchion = new Weapon("Falchion", 95);
Weapon longsword = new Weapon("Longsword", 105);

Armour fortress = new Armour("The Iron Fortress", 55);
Armour Oath = new Armour("Death´s Oath", 65);
Armour Dome = new Armour("The Brass Dome", 70);

Monster hirocervus = new Monster("Hirocervus", 780);
Monster manticore = new Monster("Manticore", 760);
Monster mermaid = new Monster("Mermaid", 750);

Hero.ShowStats(william);

Menu.GetPlayersName();
Menu.MainMenu();
class Hero
{
    public string HeroName { get; set; }

    public int HeroOriginalHealth { get; set; }

    public int HeroCurrentHealth { get; set; }
    public int HeroBaseStrength { get; set; }
    public int HeroBaseDefense { get; set; }

    public HashSet<Hero> Heroes { get; set; }
    public Hero(string heroname,int herohealth)
    {
        HeroName = heroname;
        HeroOriginalHealth = herohealth;
        HeroCurrentHealth = herohealth;
        HeroBaseStrength = 0;
        HeroBaseDefense = 0;
        Heroes = new HashSet<Hero>();
    }

    public static void ShowStats(Hero hero)
    {

        Console.WriteLine($"Hero Name: {hero.HeroName}, BaseStrength: {hero.HeroBaseStrength}; BaseDefence: {hero.HeroBaseDefense}, OriginalHealth: {hero.HeroOriginalHealth}, Current Health: {hero.HeroCurrentHealth}");
    }
    
    
}



class Weapon
{
    public string WeaponName { get; set; }
    public int WeaponPower { get; set; }

    public HashSet<Weapon> Weapons { get; set; }

    public Weapon(string weaponname, int weaponpower)
    {
        WeaponName = weaponname;
        WeaponPower = weaponpower;
        Weapons = new HashSet<Weapon>();
    }
}

class Armour
{
    public string ArmourName { get; set; }

    public int ArmourPower { get; set; }

    public HashSet<Armour> Armours { get; set; }

    public Armour(string armourname, int armourpower)
    {
        ArmourName = armourname;
        ArmourPower = armourpower;
        Armours = new HashSet<Armour>();
    }
}

static class WeaponList
{
    public static HashSet<Weapon> Weapons { get; set; }
    
    public static void FillWeaponList()
    {
        Weapons = new HashSet<Weapon>();
    } 
    

}

static class ArmourList
{
    public static HashSet<Armour> Armours { get; set; }

    public static void FillArmourList()
    {
        Armours = new HashSet<Armour>();
    }

}
class Monster
{
    public string MonsterName { get; set; }
    public int MonsterOriginalHealth { get; set; }
    public int MonsterCurrentHealth { get; set; }
    public int MonsterStrength { get; set; }
    public int MonsterDefence { get; set; }

    public Monster(string monstername, int monsterhealth)
    {
        MonsterName = monstername;
        MonsterOriginalHealth = monsterhealth;
        MonsterCurrentHealth = monsterhealth;
        MonsterStrength = 0;
        MonsterDefence = 0;
    }


}

class Fight
{
    public int HeroFirstStrength { get; set; }
    public int EquippedWeaponPower { get; set; }
    public int HeroDamageProduced { get; set; }
    public int HeroBaseStrength { get; set; }
    public int HeroBaseDefense { get; set; }
    public int MonsterDamageProduced { get; set; }

    public int HeroTurn(int herooriginalstrength, int equippedweaponpower)
    {
        HeroFirstStrength = herooriginalstrength;
        EquippedWeaponPower = equippedweaponpower;
        HeroDamageProduced = HeroFirstStrength + EquippedWeaponPower;
        return HeroDamageProduced;
    }

    public int Monsterturn(int herobasestrength, int herobasedefense)
    {
        HeroBaseStrength = herobasestrength;
        HeroBaseDefense = herobasedefense;
        MonsterDamageProduced = HeroBaseStrength - HeroBaseDefense;
        return MonsterDamageProduced;
    }
}

static class Menu
{
    public static string PlayersName { get; set; } 
    public static int NumberSelected { get; set; }
    public static string BigStringSelected { get; set; }
    public static string StringSelected { get; set; }

    public static void GetPlayersName()
    {
        Console.WriteLine("Please enter your name:");
        PlayersName = Console.ReadLine();
        string player = $"The name of the player is {PlayersName}";
        Console.WriteLine(player);
    }

    public static void StatisticsMenu()
    {
        Console.WriteLine("Please Select the option by pressing the associated letter:\n A Number of games played\n B Number of Fights Won\n C Number of Fights Lost");
        BigStringSelected = Console.ReadLine().ToUpper();
        Console.WriteLine($"Selected : {BigStringSelected}");
    }

    public static void InventoryMenu()
    {
        Console.WriteLine("Please Select the option by pressing the associated sign:\n i Change the equipped weapon\n ii Change the equipped armour\n iii Exit");
        StringSelected = Console.ReadLine().ToUpper();
        Console.WriteLine($"Selected: {StringSelected}");
    }

    public static void StartFight()
    {
        Console.WriteLine("Please Select the option by pressing the associated number:\n 1 Beginning a Fight\n 2 \n 3 ");
    }

    public static void MainMenu()
    {
        
        Console.WriteLine("Please Select the option by pressing the associated number:\n 1 Statistics\n 2 Inventory\n 3 Figth");
        NumberSelected = Int32.Parse(Console.ReadLine());
        switch (NumberSelected)
        {
            case 1:
                StatisticsMenu();
                break;
            case 2:
                InventoryMenu();
                break;
            case 3:
                StartFight();
                break;
            default:
                Console.WriteLine("Bad election");
                break;
        }
        
        
    }

}
