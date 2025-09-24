namespace homework1.homework3;

public class Task6
{
    public static void main()
    {
        //again stringbuilder much better option
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= input; i++)
        {
            if (input % i == 0)
            {
                result += (input == i) ?  i :  i + ", ";
            }
        }
        Console.WriteLine("divisors of " + input + " are : " +  result);
    }
}