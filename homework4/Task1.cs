namespace homework1.homework4;

public class Task1
{
    public static void Main()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number for index " + i + ": ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[i] = val;
        }
        Console.WriteLine("Here is your array!");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    
}