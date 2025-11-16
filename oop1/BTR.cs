namespace homework1.homework12;

public class BTR : CombatVehicle
{
    public int WheelConfiguration { get; protected set; } 

    public BTR(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        string mainWeapon, int mainWeaponAmmo, int crewCapacity, int wheelConfiguration)
        : base(make, model, year, maxSpeed, weight, engineType, mainWeapon, mainWeaponAmmo, crewCapacity)
    {
        WheelConfiguration = wheelConfiguration;
        
    }

    public override void FireMainWeapon()
    {
        if (MainWeaponAmmo > 0)
        {
            Console.WriteLine($"BTR {Make} {Model} firing {MainWeapon}");
            MainWeaponAmmo--;
        }
        else
        {
            Console.WriteLine($"BTR {Make} {Model} is out of {MainWeapon} ammo!");
        }
    }

    public override void InspectMainWeapon()
    {
        Console.WriteLine($"Checking the {MainWeapon} on BTR {Make} {Model}");
    }

    public void DeployTroops()
    {
        Console.WriteLine($"BTR {Make} {Model} deploying {CrewCapacity - 2} troops!");
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Wheel Configuration: {WheelConfiguration}x{WheelConfiguration}");
        
    }
}