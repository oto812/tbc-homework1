namespace homework1.Recursion;

public class Task1
{
    public static void main()
    {
        
        printNumsTail(13);
        
    }

    public static void printNums(int n)
    {
        if (n <= 0) return;
        printNums(n - 1);
        Console.Write($"{n} ");
    }
    //tail recursive approach
    public static void printNumsTail(int n)
    {
        helper(n,"");
        
    }
    public static void helper(int n, string curResult)
    {
        if (n <= 0)
        {
            Console.WriteLine(curResult);
            return;
        }
        helper(n - 1,  $"{n} {curResult}");
    }
}