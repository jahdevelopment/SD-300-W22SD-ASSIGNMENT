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
Menu.ShowStats(william);
Menu.GetPlayersName();
Menu.MainMenu();
public class Hero
{
    public string HeroName { get; set; }

    public int HeroOriginalHealth { get; set; }

    public int HeroCurrentHealth { get; set; }
    public int HeroBaseStrength { get; set; }
    public int HeroBaseDefense { get; set; } 
    public int NumOfHeroSelected { get; set; }

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

    //public Hero RegisterHero(string heroname, int herohealth)
    //{
    //    Hero newHero = new Hero(heroname, herohealth);
    //    Heroes.Add(newHero);
    //    return newHero;
    //}

    //public static void ShowStats(Hero hero)
    //{
    //    Console.WriteLine($"Hero Name: {hero.HeroName}, BaseStrength: {hero.HeroBaseStrength}; BaseDefence: {hero.HeroBaseDefense}, OriginalHealth: {hero.HeroOriginalHealth}, Current Health: {hero.HeroCurrentHealth}");
    //}
    
    
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

    public static int ChooseAHero { get; set; }
    
    public static void GetPlayersName()
    {
        Console.WriteLine("Please enter your name:");
        PlayersName = Console.ReadLine();
        string player = $"Hello {PlayersName} welcome to The most epic Medieval battle!!!";
        Console.WriteLine(player);
    }

    public static void StatisticsMenu()
    {
        Console.WriteLine("STATISTICS: Please Select the option by pressing the associated letter:\n A: Number of games played\n B: Number of Fights Won\n C: Number of Fights Lost\n D: Return to the main menu");
        BigStringSelected = Console.ReadLine().ToUpper();
        switch (BigStringSelected)
        {
            case "A":
                Console.WriteLine();
                break;
            case "B":
                Console.WriteLine();
                break;
            case "C":
                Console.WriteLine();
                break;
            case "D":
                MainMenu();
                break;
            default: Console.WriteLine("Wrong selection please try again");
                StatisticsMenu();
                break;
        }
    }

    public static void InventoryMenu()
    {
        Console.WriteLine("INVENTORY: Please Select the option by pressing the associated leter:\n i: Select or Change the equipped weapon\n j: Select or Change the equipped armour\n k: Return to the main menu");
        StringSelected = Console.ReadLine();
        switch (StringSelected)
        {
            case "i":
                Console.WriteLine();
                break;
            case "j":
                Console.WriteLine();
                break;
            case "k":
                MainMenu();
                break;
            default:
                Console.WriteLine("Wrong selection please try again");
                InventoryMenu();
                break;
        }
    }

    public static void ShowStats(Hero hero)
    {
        Console.WriteLine($"Hero Name: {hero.HeroName}, BaseStrength: {hero.HeroBaseStrength}; BaseDefence: {hero.HeroBaseDefense}, OriginalHealth: {hero.HeroOriginalHealth}, Current Health: {hero.HeroCurrentHealth}");
    }

    public static void SelectedHero(int chooseahero)
    {
        
        switch (chooseahero)
        {
            case 1:
                Console.WriteLine("Good choice!!! Your Hero selected is: ***WILLIAM WALLACE***");
                break;
            case 2:
                Console.WriteLine("Awesome!!! with ***RODRIGO DIAZ DE VIVAR*** you will have a lot of chance to win!!");
                break;
            case 3:
                Console.WriteLine("That´s the best ellection possible!! ***SAINT GEORGE*** is ver powerfull!!");
                break;
            default: Console.WriteLine("Your search is not giving any results, please try again");
                SelectedHero(chooseahero);
                break;
        }
    }

    public static void SelectHero()
    {
        Console.WriteLine($"SELECT HERO: Please Select the option by pressing the associated number:\n 0: To Know statistic of the Hero of your interest.\n 1: Select ***WILLIAM WALLACE***\n 2: Select ***RODRIGO DIAZ DE VIVAR***\n 3: Select ***SAINT GEORGE***\n 4: Change your Hero selected\n 5: Return to Fight Menu" );
        NumberSelected = Int32.Parse(Console.ReadLine());
        switch (NumberSelected)
        {
            case 0:
                Console.WriteLine("STATISTICS OF A HERO: Write the number of the Hero of your interest:\n 1: William Wallace\n 2: Rodrigo Diaz De Vivar\n 3: Saint George");
                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        //Console.WriteLine($"BaseStrength: {hero.HeroBaseStrength}; BaseDefence: {william.HeroBaseDefense}, OriginalHealth: {william.HeroOriginalHealth}, Current Health: {william.HeroCurrentHealth}");
                        SelectHero();
                        break;
                    case 2:
                        //ShowStats(Hero hero);
                        SelectHero();
                        break;
                    case 3:
                        //Hero.ShowStats();
                        SelectHero();
                        break;
                    default: Console.WriteLine("Your search is not giving any results, please try again");
                        SelectHero();
                        break;
                }
                
                break;
            case 1:
                SelectedHero(1);
                break;
            case 2:
                SelectedHero(2);
                break;
            case 3:
                SelectedHero(3);
                break;
            case 4:
                Console.WriteLine();
                break;
            case 5:
                StartFight();
                break;
            default:
                Console.WriteLine("Wrong selection, please try again");
                SelectHero();
                break;
        }
    }   

    public static void StartFight()
    {
        Console.WriteLine("FIGHT: Please Select the option by pressing the associated number:\n 1: Select a Hero\n 2: Select a Monster\n 3: Beginning a Fight\n 4: Return to the main menu");
        NumberSelected = Int32.Parse(Console.ReadLine());
        switch (NumberSelected)
        {
            case 1:
                SelectHero();
                break;
            case 2:
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine();
                break;
            case 4:
                MainMenu();
                break;
            default: Console.WriteLine("Wrong selection, please try again");
                StartFight();
                break;
        }
    }

    public static void MainMenu()
    {
        
        Console.WriteLine("MAIN MENU: Please Select the option by pressing the associated number:\n 1: STATISTICS\n 2: INVENTORY\n 3: FIGHT");
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
                Console.WriteLine("Wrong election, select again");
                MainMenu();
                break;
        }
         
    }

}
