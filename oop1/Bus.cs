namespace homework1.homework12;

public class Bus : PublicVehicle, ICargo 
{
    public int StandingCapacity { get; protected set; }
    public int StartingHour { get; protected set; }
    public int EndingHour { get; protected set; }
    

    public Bus(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        string[] route, int currentStopIndex, int costOfRide, int standingCapacity, int startingHour, int endingHour)
        : base(make, model, year, maxSpeed, weight, engineType, route, currentStopIndex, costOfRide)
    {
        StandingCapacity = standingCapacity;
        StartingHour = startingHour;
        EndingHour = endingHour;
        
    }

    public void OpenDoors()
    {
        Console.WriteLine($"Doors of {Make} {Model} bus are opening for passengers.");
    }

    public void CloseDoors()
    {
        Console.WriteLine($"Doors of {Make} {Model} bus are closing");
    }

    public void LoadCargo()
    {
        Console.WriteLine($"Loading luggage into the cargo {Make} {Model} bus.");
    }

    public void EmptyCargo()
    {
        Console.WriteLine($"Unloading luggage from the cargo {Make} {Model} bus.");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Standing Capacity: {StandingCapacity}");
        Console.WriteLine($"  Starting Hour: {StartingHour}");
        Console.WriteLine($"  Ending Hour: {EndingHour}");
    }
}
