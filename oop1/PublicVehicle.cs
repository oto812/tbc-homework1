namespace homework1.homework12;

public abstract class PublicVehicle : Vehicle
{
    public string[] Route { get; protected set; }
    public int NextStop { get; protected set; }

    public int CostOfRide { get; protected set; }

    public override void Drive()
    {
        Console.WriteLine($"public vehicle {Make} {Model} driving to the next stop");
        NextStop = (NextStop + 1) % Route.Length;
    }
    
    public void AnnounceNextStop()
    {
        Console.WriteLine($"Next stop: {Route[NextStop]}. Please prepare to exit.");
    }

    protected PublicVehicle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        string[] route, int nextStop, int costOfRide) : base(make, model, year, maxSpeed, weight, engineType)
    {
        Route = route;
        NextStop = nextStop;
        CostOfRide = costOfRide;
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Route: {string.Join(", ", Route)}");
        Console.WriteLine($"  Current Stop: {Route[NextStop]}");
        Console.WriteLine($"  Cost of Ride: {CostOfRide}");
       
    }
    
    
    
    
    
    
    
    
    
}