namespace homework1.homework3;

public class Task7
{
    public static void main()
    {
        //in the example you had 9 numbers of fibonnaci when input was 8 so i wrote program accordingly
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        int prev = 0;
        int cur = 1;

        string result = input == 0 ? "0" : "0, ";
        for (int i = 0; i < input; i++)
            {
                result += (i == input-1 ) ? cur  : cur + ", ";
                cur += prev;
                prev = cur - prev;
            }
            
            Console.WriteLine(result);

        }
    
}