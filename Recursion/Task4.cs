namespace homework1.Recursion;

public class Task4
{
    public static void main()
    {
        Console.WriteLine(pow(2,0));
        Console.WriteLine(powTail(2,2));
    }

    // assume that degree input is not negative 
    public static int pow(int number, int degree)
    {
        if (degree == 0)
        {
            return 1;
        }
        if (degree == 1)
        {
            return number;
        }
        
        return number * pow(number, degree-1);
    }
    
    // tailrecursive

    public static int powTail(int number, int degree)
    {
        if (degree == 0)
        {
            return 1;
        }
        return helper(number, degree, number);
    }

    public static int helper(int number, int degree, int res)
    {
        if (degree == 1)
        {
            return res;
        }
        return helper(number, degree-1, res*number);
    }
}