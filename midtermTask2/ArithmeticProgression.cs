namespace homework1.midtermTask2;

public class ArithmeticProgression
{
    public static void main()
    {
        int[] arr = {1};
        Console.WriteLine(IsArithmeticProgression(arr));
    }

    public static bool IsArithmeticProgression(int[] arr)
    {
        if (arr.Length == 0)
        {
            return true;
        }
        int max = Max(arr);
        int min = Min(arr);
        int difference = (max + min)/ arr.Length;
        
        while (min != max)
        {
            min += difference;
            // with Hashsets we would reduce time complexity to O(n)
            if (!consists(arr, min))
            {
                return false;
            }
            
        }
        return true;

    }

    public static bool consists(int[] arr,int num)
    {
        bool result = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                result = true;
            }
        }

        return result;
    }

    public static int Max(int[] arr)
    {
        int result = Int32.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > result)
            {
                result = arr[i];
            }
        }
        return result;
    }
    public static int Min(int[] arr)
    {
        int result = Int32.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < result)
            {
                result = arr[i];
            }
        }
        return result;
    }
}