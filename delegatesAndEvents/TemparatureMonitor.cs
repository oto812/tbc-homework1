namespace homework1.delegates_events;

public class TemparatureMonitor
{
    public delegate void NotifyCriticalTemparature(int temperature);
    public event NotifyCriticalTemparature? CriticalTemparature;

    public void CheckTemparature(int temperature)
    {
        if (temperature < 0 || temperature > 40)
        {
            OnCriticalTemparature(temperature);
        }
    }

    public void OnCriticalTemparature(int temperature)
    {
        CriticalTemparature?.Invoke(temperature);
    }
    
}