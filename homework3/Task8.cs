namespace homework1.homework3;

public class Task8
{
    public static void main()
    {
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int temp = input;

        string binary = "";

        while (temp != 0)
        {
            binary = temp % 2 == 0 ? "0" + binary : "1" + binary;
            temp /= 2;
        }
        Console.WriteLine("decimal " + input + " in binary is " + binary);
        


    }
    
}