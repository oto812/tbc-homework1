namespace homework1.homework4;

public class Task6
{
    public static void Main()
    {
        Console.Write("Enter array row size: ");
        int row = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter array column size: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("Enter number for index " + i + ","+ j + ": ");
                int value = Convert.ToInt32(Console.ReadLine());
                matrix[i, j] = value;
            }
        }
        
        Console.WriteLine("Here is matrix view of multidimensional array");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
            }
            Console.WriteLine();
        }
        
    }
}