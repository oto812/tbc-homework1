namespace homework1.homework12;

public class Sedan : CommercialVehicle
{
    public int TrunkCapacity { get; protected set; } 
    public bool HasSunroof { get; protected set; }

    public Sedan(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int passengerSeats, ComfortLevel comfortLevel, int cargoCapacity, int trunkCapacity, bool hasSunroof)
        : base(make, model, year, maxSpeed, weight, engineType, passengerSeats, comfortLevel, cargoCapacity)
    {
        TrunkCapacity = trunkCapacity;
        HasSunroof = hasSunroof;
    }

    public void OpenSunroof()
    {
        if (HasSunroof)
        {
            Console.WriteLine($"Sunroof of {Make} {Model} is opening");
        }
        else
        {
            Console.WriteLine($"{Make} {Model} does not have a sunroof.");
        }
    }

    public override void Drive()
    {
        Console.WriteLine($"driving in the {Make} {Model} sedan");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Trunk Capacity: {TrunkCapacity} liters");
        Console.WriteLine($"  Has Sunroof: {HasSunroof}");
    }
}