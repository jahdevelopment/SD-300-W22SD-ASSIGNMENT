class Hero
{
    public string HeroName { get; set; }

    public int HeroOriginalHealth { get; set; }

    public int HeroCurrentHealth { get; set; }

    public HashSet<Weapon> Weapons {  get; set; }
    public HashSet<Armour> Armours { get; set; }


}

class Weapon
{
    public string WeaponName { get; set; }
    public int WeaponPower { get; set; }

    public HashSet<Weapon> Weapons { get; set; }

    public Weapon(string weaponName, int weaponPower)
    {
        WeaponName = weaponName;
        WeaponPower = weaponPower;
        Weapons = new HashSet<Weapon>();
    }
}

class Armour
{
    public string ArmourName { get; set; }

    public int ArmourPower { get; set; }

    public HashSet<Armour> Armours { get; set; }

    public Armour(string armourName, int armourPower)
    {
        ArmourName = armourName;
        ArmourPower = armourPower;
    }
}

static class WeaponList
{
   


}

static class ArmourList
{

    
}
