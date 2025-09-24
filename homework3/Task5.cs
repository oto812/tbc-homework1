namespace homework1.homework3;

public class Task5
{
    public static void main()
    {
        //better way would be to use stringbuilder but we haven't learned it yet
        Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
        int input = Convert.ToInt32(Console.ReadLine());
        string currentLine = "1";
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(currentLine);
            currentLine = (i % 2 == 0 ? "0" : "1") + currentLine;
        }
    }
}