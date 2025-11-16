namespace homework1.Recursion;

public class Task2
{
    public static void main()
    {
        Console.WriteLine(sum(13));
        Console.WriteLine(sumTail(13));
    }

    public static int sum(int num)
    {
        
        if (num <= 0)
        {
            return 0;
        }
        return num + sum(num - 1);
    }
    
    // tail recusrive 
    public static int sumTail(int num)
    {
        return helper(num, 0);
    }

    public static int helper(int num, int curSum)
    {
        if (num <= 0) return curSum;
        return helper(num-1, num + curSum) ;
    }
}