namespace homework1.homework12;
public enum ComfortLevel{VeryLow, Low, Medium, High, VeryHigh}

public abstract class CommercialVehicle: Vehicle
{
    public int PassengerSeats { get; protected set; }
    public ComfortLevel ComfortLevel { get; protected set; }
    public int CargoCapacity { get; protected set; }

    protected CommercialVehicle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int passengerSeats, ComfortLevel comfortLevel, int cargoCapacity) :
        base(make, model, year, maxSpeed, weight, engineType)
    {
        PassengerSeats = passengerSeats;
        ComfortLevel = comfortLevel;
        CargoCapacity = cargoCapacity;
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving Commercial model {Make} {Model}");
    }
    
    public override void PrintInfo()
            {
                base.PrintInfo();
                Console.WriteLine($"  Passenger Seats: {PassengerSeats}");
                Console.WriteLine($"  Comfort Level: {ComfortLevel}");
                Console.WriteLine($"  Cargo Capacity: {CargoCapacity} kg");
                
            }
    
    
    
  }