namespace homework1.streams;

public class City : GeographicEntity
{
    public int PopulationValue { get; set; }
    public bool IsCapital { get; set; }
    public Country Country { get; set; }

    public override int Population => PopulationValue;

    public override double? Area { get; }

    public City(string cityName, double area, int population, bool isCapital, Country country) : base(cityName)
    {
        Area = area;
        PopulationValue = population;
        IsCapital = isCapital;
        Country = country;
    }
}