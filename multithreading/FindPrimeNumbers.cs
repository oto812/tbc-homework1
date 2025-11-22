using System.Diagnostics;

namespace homework1.multithreading;

public class FindPrimeNumbers
{
    static List<int> primesList = new List<int>();
   
    public static void Main()
    {
        Console.Write("Enter the start of the range: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the range: ");
        int finalEnd = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers of threads to use: ");
        int threads = int.Parse(Console.ReadLine());
        
        List<Thread> threadList = new List<Thread>();
        int chunkSize = (finalEnd - start + 1)/ threads;
        
        
        Stopwatch stopwatch = Stopwatch.StartNew();

        
        for (int i = 0; i < threads; i++)
        {
            
            int threadStart = start;
            int threadEnd = (i == threads - 1) ? finalEnd : start + chunkSize + 1;

            Thread thread = new Thread(() => FindPrimes(threadStart, threadEnd));
            threadList.Add(thread);
            thread.Start();

            start = threadEnd + 1;
        }

        foreach (Thread thread in threadList)
        {
            thread.Join();
        }
        
        stopwatch.Stop();
        primesList.Sort();
        
        

        foreach (var prime in primesList)
        {
            Console.WriteLine(prime);
        }
        
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
    }
    public static void FindPrimes(int from, int to)
    {
        for (int i = from; i <= to; i++)
        {
            if (IsPrime(i))
            {
                lock (primesList)
                {
                    primesList.Add(i);
                }
            }
        }
    }

    public static bool IsPrime(int number)
    {
        if(number == 1)  return false;
        if(number == 2)  return true;
        int limit = (int)Math.Sqrt(number);
        for (int i = 2; i <= limit; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    
    
    
}