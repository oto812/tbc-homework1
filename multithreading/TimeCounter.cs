using System.Diagnostics;

namespace homework1.multithreading;

public class TimeCounter
{
    public static void Main()
    {
        
        Stopwatch stopwatch = Stopwatch.StartNew();
        bool isStopped = false;
        
        

        Thread thread = new Thread(() =>
        {
            while (!isStopped)
            {
                Console.Write($"\rElapsed time: {stopwatch.Elapsed.TotalSeconds:F1} seconds : ");
                Thread.Sleep(1000); 
            }
        });
        thread.Start();

        
        Console.WriteLine("Enter Q for quit or R for time restart");
        string input = Console.ReadLine();
        while (input != "Q")
        {
            if (input == "R")
            {
                stopwatch.Restart();
            }
            input = Console.ReadLine();
        }
        isStopped = true;
    }
}