namespace homework1.Homework5;

public class Task3
{
    public static void Main()
    {
        minMax(fillArray());
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

    public static int[] minMax(int[] arr)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("the minimum number in the array is " + min);
        Console.WriteLine("the Maximum number in the array is " + max);

        return new int[] { min, max };
    }
}