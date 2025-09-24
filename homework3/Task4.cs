namespace homework1.homework3;

public class Task4
{
    public static void main()
    {
        Console.Write("Enter number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int sumOfOdd = 0;
        for (int i = 110; i <= input; i += 2)
        {
            sumOfOdd += i;
        }
        Console.WriteLine("sum of odd numbers from 1 to " + input + " is " + sumOfOdd);
    }
}