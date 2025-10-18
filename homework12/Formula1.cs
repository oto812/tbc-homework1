namespace homework1.homework12;

public class Formula1 : SportVehicle
{
    public string TireCompound { get; protected set; }
    public bool HasDRS { get; protected set; } //drag reduction system

    public Formula1(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int competitionWinnings, bool isCustomized, string tireCompound, bool hasDRS)
        : base(make, model, year, maxSpeed, weight, engineType, competitionWinnings, isCustomized)
    {
        TireCompound = tireCompound;
        HasDRS = hasDRS;
    }

    public void ActivateDRS()
    {
        if (HasDRS)
        {
            Console.WriteLine($"DRS activated on {Make} {Model} Formula 1 car");
        }
        else
        {
            Console.WriteLine($"{Make} {Model} does not have DRS.");
        }
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Make} {Model} Formula 1 is driving really fast");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Tire Compound: {TireCompound}");
        Console.WriteLine($"  Has DRS: {HasDRS}");
    }
}