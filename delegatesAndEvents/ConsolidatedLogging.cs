namespace homework1.delegates_events;

public class ConsolidatedLogging
{
    public delegate void LogMessage(string message);
    
    static public void ConsoleLogMessage(string message)
    {
        Console.WriteLine(message);
    }

    static public void FileLogMessage(string message)
    {
        File.AppendAllText("ConsolidatedLog.txt", message);
    }
    
    public static void Main()
    {
        LogMessage logMessage = new LogMessage(ConsoleLogMessage);
        logMessage += FileLogMessage;
        logMessage("Hello!");
    }

}
