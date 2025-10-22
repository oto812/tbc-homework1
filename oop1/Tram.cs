namespace homework1.homework12;

public class Tram : PublicVehicle
{
    // I used AI to come up with attribute names because my mind is overloaded :)
    public int NumberOfCars { get; protected set; }
    public bool IsPantographUp { get; protected set; }

    public Tram(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        string[] route, int currentStopIndex, int costOfRide, int numberOfCars,
        bool isPantographUp)
        : base(make, model, year, maxSpeed, weight, engineType, route, currentStopIndex, costOfRide)
    {
        NumberOfCars = numberOfCars;
        IsPantographUp = isPantographUp;
    }

    public void RaisePantograph()
    {
        if (!IsPantographUp)
        {
            IsPantographUp = true;
            Console.WriteLine($"Pantograph of {Make} {Model} tram raised. Ready for power.");
        }
        else
        {
            Console.WriteLine($"Pantograph of {Make} {Model} is already up.");
        }
    }
    public void LowerPantograph()
    {
        if (IsPantographUp)
        {
            IsPantographUp = false;
            Console.WriteLine($"Pantograph of {Make} {Model} tram lowered.");
        }
        else
        {
            Console.WriteLine($"Pantograph of {Make} {Model} is already down.");
        }
    }

    public override void Drive()
    {
        if (IsPantographUp)
        {
            Console.WriteLine($"The {Make} {Model} tram is gliding along its tracks, heading to {Route[NextStop]}.");
            NextStop = (NextStop + 1) % Route.Length;
        }
        else
        {
            Console.WriteLine($"Cannot drive {Make} {Model} tram, pantograph is not raised for power.");
        }
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Number of Cars: {NumberOfCars}");
        Console.WriteLine($"  Pantograph Up: {IsPantographUp}");
    }
}