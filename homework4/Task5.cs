namespace homework1.homework4;

public class Task5
{
    public static void Main()
    {
        
        /* in scope of our learning we could use frequency array to reduce time  
        complexity to O(n) but if we have large numbers in our array we would have memory problem.
        */
            
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter number for index " + i + ": ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[i] = val;
        }

        Console.WriteLine("unique elements of array are ");
        for (int i = 0; i < arr.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && i != j)
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}