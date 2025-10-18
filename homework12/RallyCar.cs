namespace homework1.homework12;

public class RallyCar : SportVehicle
{
    public string SuspensionType { get; protected set; }
    public bool HasRollCage { get; protected set; }

    public RallyCar(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int competitionWinnings, bool isCustomized, string suspensionType, bool hasRollCage)
        : base(make, model, year, maxSpeed, weight, engineType, competitionWinnings, isCustomized)
    {
        SuspensionType = suspensionType;
        HasRollCage = hasRollCage;
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Make} {Model} Rally Car is driving");
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Suspension Type: {SuspensionType}");
        Console.WriteLine($"  Has Roll Cage: {HasRollCage}");
    }
}