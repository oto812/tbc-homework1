namespace homework1;

public class Task3
{
    public static void Main()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number for index " + i + ": ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[i] = val;
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum of array elements is " + sum);
    }
}