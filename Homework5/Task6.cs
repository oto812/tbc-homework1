namespace homework1.Homework5;

public class Task6
{
    public static void Main()
    {
        countOccur(fillArray(),'a');

    }
    
    
    public static void print(int count, char letter)
    {
            Console.WriteLine($"'{letter}' shegvxvda {count}-jer");
    }

    public static int countOccur(char[] arr, char letter)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == letter)
            {
                count++;
            }
        }

        print(count,letter);
        return count;

    }
    
    
    public static char[] fillArray()
    {
        Console.Write("Enter size of array: ");
        int input = Convert.ToInt32(Console.ReadLine());
        char[] arr = new char[input];
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter Character for index " + i + ": ");
            char ch = Convert.ToChar(Console.ReadLine());
            arr[i] = ch;
        }
        return arr;

    }
}