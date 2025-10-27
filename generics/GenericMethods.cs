namespace homework1.generics;

public static class GenericMethods
{
    public static void GenericSwap<T>(T[] array, T firstElement, T secondElement)
    {
        if (array.Length <= 1)
            throw new ArgumentException("array should have at least two elements");

        int index1 = Array.IndexOf(array, firstElement);
        int index2 = Array.IndexOf(array, secondElement);
        if (index1 == -1)
        {
            throw new ArgumentException("first element not found found in array");
        } 
        if (index2 == -1)
        {
            throw new ArgumentException("second element not found in array");
        }

        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    
    public static T MaxFinder<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length == 0)
            throw new ArgumentException("Array cannot be empty.");
        
        T max = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i];
            }
        }

        return max;
    }
}
    

