namespace homework1.oop2and3;

public static class IntArrayExtensions
{
    public static int[] RemoveDuplicates(this int[] array)
    {
        int[] newArr = new int[array.Length];
        int uniqueCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            
            for (int j = 0; j < uniqueCount; j++)
            {
                if (array[i] == newArr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                newArr[uniqueCount] = array[i];
                uniqueCount++;
            }
        }
        int[] result = new int[uniqueCount];
        for (int i = 0; i < uniqueCount; i++)
            result[i] = newArr[i];

        return result;
    }

    public static bool Contains(this int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    public static int Max(this int[] array)
    {
       int max = int.MinValue;
       for (int i = 0; i < array.Length; i++)
       {
           if (array[i] > max)
           {
               max = array[i];
           }
       }

       return max;
    }

    public static int[] Merge(this int[] array1, int[] array2)
    {
        int arr1Size = array1.Length;
        int arr2Size = array2.Length;
        int[] result = new int[arr1Size + arr2Size];
        int curIndex = 0;
        while (curIndex < arr1Size)
        {
            result[curIndex] = array1[curIndex];
            curIndex++;
        }

        while (curIndex - arr1Size < arr2Size)
        {
            result[curIndex] = array2[curIndex-arr1Size];
            curIndex++;
        }

        return result;

    }

    public static string StringRepresentation(this int[] array, string separator)
    {
        return string.Join(separator, array);
    }
    
    
}