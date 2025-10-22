namespace homework1.homework12;

public class Jeep : CommercialVehicle
{
    public bool HasFourWheelDrive { get; protected set; }
    

    public Jeep(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int passengerSeats, ComfortLevel comfortLevel, int cargoCapacity, bool hasFourWheelDrive)
        : base(make, model, year, maxSpeed, weight, engineType, passengerSeats, comfortLevel, cargoCapacity)
    {
        HasFourWheelDrive = hasFourWheelDrive;
       
    }

    private void EngageFourWheelDrive()
    {
        
        Console.WriteLine($"engaging 4WD in {Make} {Model}. Ready for off-road!");
        
        
    }

    public override void Drive()
    {
        if (HasFourWheelDrive)
        {
            EngageFourWheelDrive();
        }
        else
        {
            Console.WriteLine($"driving {Make} {Model} jeep ");
        }
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Four Wheel Drive: {HasFourWheelDrive}");
    }
}