namespace homework1.Recursion;

public class Task3
{
    public static void main()
    {
        Console.WriteLine(countDigits(999));
        countDigitsTail(999);
    }

    public static int countDigits(int num)
    {
        if (num == 0) return 0;
        return 1 + countDigits(num / 10);
    }
    
    // tail recursive 

    public static void countDigitsTail(int num)
    {
        helper(num, 0);
    }

    public static void helper(int num, int result)
    {
        if (num == 0)
        {
            Console.WriteLine(result);
            return;
        }
        helper(num/10, result + 1);
        
    }
}