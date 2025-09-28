namespace homework1.Homework5;

public class Task2
{
    public static void Main()
    {
        int[] arr = { 1, 3, 123 };
        int index = 2;

        sumOfDigits(arr, index);

    }

    public static int sumOfDigits(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("index is out of range");
            return -1;
        }
        int temp = arr[index];
        int result = 0;
        while (temp != 0)
        {
            result += temp % 10;
            temp /= 10;
        }
        Console.WriteLine("The sum of the digits of a number at index " + index + " is " + result);
        return result;
    }
    
     
}