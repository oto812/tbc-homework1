namespace homework1.homework12;

public abstract class SportVehicle : Vehicle
{
    public int CompetitionWinnings { get; set; }
    public bool IsCustomized { get; set; }

    public void Customize()
    {
        IsCustomized = true;
        Console.WriteLine($"Customizing SportVehicle {Make} {Model}");
    }
    
    

    public override void Drive()
    {
        Console.WriteLine($"driving SportVehicle {Make} {Model}");
    }

    protected SportVehicle(string make, string model, int year, int maxSpeed, double weight, EngineType engineType,
        int competitionWinnings, bool isCustomized) : base(make, model, year, maxSpeed, weight, engineType)
    {
        CompetitionWinnings = competitionWinnings;
        IsCustomized = isCustomized;
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"  Competition Winnings: {CompetitionWinnings}");
        Console.WriteLine($"  Is Customized: {IsCustomized}");
       
    }
    
    
    
    
}