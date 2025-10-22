namespace homework1.homework12;

public abstract class CombatVehicle : Vehicle, IFire
{
    public string? MainWeapon { get; protected set; }
    public int MainWeaponAmmo { get; protected set; }
    public int CrewCapacity { get; protected set; } 
    

    public abstract void FireMainWeapon();
    public abstract void InspectMainWeapon();

    public void ReloadMainWeapon()
    {
        Console.WriteLine($"realoading main weapon for {Make} {Model}");
    }
   

    public override void Drive()
    {
        Console.WriteLine($"driving combat vehicle {Make} {Model} with low speed");
    }

    protected CombatVehicle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType, string mainWeapon,
        int mainWeaponAmmo, int crewCapacity) : base(make, model, year, maxSpeed, weight, engineType)
    {
        MainWeapon = mainWeapon;
        MainWeaponAmmo = mainWeaponAmmo;
        CrewCapacity = crewCapacity;
        
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Main Weapon: {MainWeapon}");
        Console.WriteLine($"  Ammo: {MainWeaponAmmo}");
        Console.WriteLine($"  Crew Capacity: {CrewCapacity}");
        
    }
    
    
}