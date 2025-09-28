namespace homework1.Homework5;

public class Task8
{
    public static void main()
    {
        expandedFormOfInteger();
    }

    public static void expandedFormOfInteger()
    {
        Console.WriteLine("Enter a positive integer: ");
        
        int input = Convert.ToInt32(Console.ReadLine());
        if (input < 0)
        {
            Console.WriteLine("invalid input");
        }
        int num = input;
        string result = "";
        int power  = 0;
        while (num != 0)
        {
            result =  num >= 10 ? $" + {num % 10} * 10^{power}" + result :$"{num % 10} * 10^{power}" + result ;
            power++;
            num = num / 10;
            

        }
        Console.WriteLine($"{input} = " + result);

        
    }
}
