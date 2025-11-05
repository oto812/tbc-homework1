namespace homework1.streams;

public abstract class GeographicEntity
{
    public string Name { get; }

    public abstract int Population { get; }
    public abstract double? Area { get; }

    protected GeographicEntity(string name)
    {
        Name = name;
    }
    
    

}