namespace homework1.Homework5;

public class Task4
{
    public static void Main()
    {
        arithmeticAvg(fillArray());
        
    }

    public static double arithmeticAvg(int[] arr)
    {
        double sum = 0d;
        for (int i = 0; i < arr.Length; i++)
        {
                sum += arr[i];
        }
        double avg =sum / arr.Length;
        Console.WriteLine("Arithmetic average of array is " + avg );
        return avg;
    }
    
    public static int[] fillArray()
    {
        Console.Write("Enter size of array: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[input];
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter integer for index " + i + ": ");
            int value = Convert.ToInt32(Console.ReadLine());
            arr[i] = value;
        }
        return arr;
    }
}