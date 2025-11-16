namespace homework1.streams;

public class Country : GeographicEntity
{
    public List<City> Cities { get; }
    public override int Population { get
    {
        int population = 0;
        for (int i = 0; i < Cities.Count; i++) population += Cities[i].Population;
        return population;
    } 
    }
    public override double? Area { 
        get
        {
            double? area = 0;
            for (int i = 0; i < Cities.Count; i++) area += Cities[i].Area;
            return area;
        }
    }

    public Country(string name, List<City> cities) : base(name)
    {
        Cities = cities;
    }
    

}