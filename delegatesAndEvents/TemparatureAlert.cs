namespace homework1.delegates_events;

public class TemparatureAlert
{
    public void Alert(int temperature)
    {
        Console.WriteLine($"Alert! Critical temperature detected: {temperature}\u00b0C");
    }
}