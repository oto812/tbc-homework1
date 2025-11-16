namespace homework1.homework12;

public class Bicycle : CommercialVehicle
{
    public int NumberOfGears { get; protected set; }
    public bool HasBasket { get; protected set; }

    public Bicycle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int passengerSeats, ComfortLevel comfortLevel, int cargoCapacity, int numberOfGears, bool hasBasket)
        : base(make, model, year, maxSpeed, weight, engineType, passengerSeats, comfortLevel, cargoCapacity)
    {
        NumberOfGears = numberOfGears;
        HasBasket = hasBasket;
    }

    public void RingBell()
    {
        Console.WriteLine($"ringing The {Make} {Model} bicycle bell");
    }

    public override void Drive()
    {
        Console.WriteLine($"Pedaling the {Make} {Model} bicycle, enjoying the fresh air.");
    }

    
    public override void StartEngine()
    {
        Console.WriteLine("A bicycle doesn't have an engine");
    }

    public override void StopEngine()
    {
        Console.WriteLine("A bicycle doesn't have an engine");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Number of Gears: {NumberOfGears}");
        Console.WriteLine($"  Has Basket: {HasBasket}");
    }
}