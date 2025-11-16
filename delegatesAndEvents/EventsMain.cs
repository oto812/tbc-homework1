namespace homework1.delegates_events;

public class EventsMain
{
    public static void main()
    {
        TemparatureMonitor monitor = new TemparatureMonitor();
        TemparatureAlert alert = new TemparatureAlert();
        monitor.CriticalTemparature += alert.Alert;
        
        Console.Write("Enter temperature:  ");
        string temperature = Console.ReadLine();
        
        while (temperature != "exit")
        {
            int temperatureInt = Convert.ToInt32(temperature);
            monitor.CheckTemparature(temperatureInt);
            Console.WriteLine();
            Console.Write("Enter temperature:  ");
            temperature = Console.ReadLine();
        }
    }
}