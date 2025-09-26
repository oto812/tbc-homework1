namespace homework1.homework4;

public class Task4
{
    public static void Main()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int prod = 1;
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number for index " + i + ": ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[i] = val;
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            prod *= arr[i];
        }
        Console.WriteLine("Product of array elements is " + prod);
    }
}