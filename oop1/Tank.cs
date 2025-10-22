namespace homework1.homework12;

public class Tank : CombatVehicle
{
    public string ArmorType { get; protected set; }
    public bool HasProtectionSystem { get; protected set; }

    public Tank(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        string mainWeapon, int mainWeaponAmmo, int crewCapacity, string armorType, bool hasProtectionSystem)
        : base(make, model, year, maxSpeed, weight, engineType, mainWeapon, mainWeaponAmmo, crewCapacity)
    {
        ArmorType = armorType;
        HasProtectionSystem = hasProtectionSystem;
    }

    public override void FireMainWeapon()
    {
        if (MainWeaponAmmo > 0)
        {
            Console.WriteLine($"Tank {Make} {Model} firing its {MainWeapon}");
            MainWeaponAmmo--;
        }
        else
        {
            Console.WriteLine($"Tank {Make} {Model} is out of {MainWeapon} ammo");
        }
    }

   

    public override void InspectMainWeapon()
    {
        Console.WriteLine($"Inspecting the {MainWeapon} on Tank {Make} {Model}");
    }
    

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Armor Type: {ArmorType}");
        Console.WriteLine($"  Active Protection System: {HasProtectionSystem}");
    }
}