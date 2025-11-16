namespace homework1.homework12;

public enum EngineType{ Combustion, Electric, Hybrid }
public abstract class Vehicle
{
    public string Make { get; protected set; }
    public string Model { get; protected set; }
    public int Year { get; protected set; }
    public int MaxSpeed { get; protected set; }
    public double Weight { get; protected set; }
    public EngineType EngineType { get; protected set; }
    public bool IsEngineRunning { get; protected set; }

    protected Vehicle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType)
    {
        Make = make;
        Model = model;
        Year = year;
        MaxSpeed = maxSpeed;
        Weight = weight;
        EngineType = engineType;
        IsEngineRunning = false;
    }

    public abstract void Drive();
    

    public virtual void StartEngine()
    {
        if (!IsEngineRunning)
        {
            IsEngineRunning = true;
        }
        else
        {
            Console.WriteLine("Engine was already running");
        }
            
        
       
    }

    public virtual void StopEngine()
    {
        if (IsEngineRunning)
        {
            IsEngineRunning = false;
        }
        else
        {
            Console.WriteLine("The vehicle was already stopped");
        }
    }
    
    public virtual void PrintInfo()
    {
        Console.WriteLine($"--- {Make} {Model} ({Year}) ---");
        Console.WriteLine($"  Type: {GetType().Name}");
        Console.WriteLine($"  Max Speed: {MaxSpeed} km/h");
        Console.WriteLine($"  Weight: {Weight} kg");
        Console.WriteLine($"  Engine Type: {EngineType}");
        Console.WriteLine($"  Engine Running: {IsEngineRunning}");
    }
    
    
}