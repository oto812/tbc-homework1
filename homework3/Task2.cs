namespace homework1.homework3;

public class Task2
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= input; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum from 1 to " + input + " is " + sum);
    }
}