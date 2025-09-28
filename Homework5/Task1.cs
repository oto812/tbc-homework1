namespace homework1.Homework5;

public class Task1
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };
        int index = 0;
        numAtIndex(arr, index);

    }

    public static int numAtIndex(int[] arr, int index)
    {
        if (index >= arr.Length || index < 0)
        {
            Console.WriteLine("index is out of range");
            return -1;
        }
        Console.WriteLine("Number at index " + index + " in the array is " + arr[index]);
        return arr[index];
    }
}