namespace homework1.midtermTask1;

public class Pairs
{
    public static void main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ShowPairs(11,a);
    }

    public static void ShowPairs(int number, int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            if (array[left] + array[right] == number)
            {
                Console.WriteLine("Pair #" + number + ": " + array[left] + ", " + array[right]);
                left++;
            }else if (array[left] + array[right] > number)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
    }
}