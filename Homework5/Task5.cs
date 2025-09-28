namespace homework1.Homework5;

public class Task5
{
    public static void Main()
    {
        tryFact(fillArray(), -3);

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

    public static int tryFact(int[] arr, int num)
    {
        if (num < 0)
        {
            Console.WriteLine("factorial is not defiend for negative numbers");
            return -1;
        }
        bool inArray = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                inArray = true;
            }
        }
        

        if (inArray)

        {
            int result = fact(num);
            Console.WriteLine("Factorial of " + num + " is " + result);
            return result;
        }
        else
        {
            Console.WriteLine("Number " + num + " was not found in the given array");
            return -1;
        }

        
    }

    public static int fact(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        return num * fact(num - 1);
    }
    
}