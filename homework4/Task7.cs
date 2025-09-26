namespace homework1.homework4;

public class Task7
{
    public static void Main()
    {
        Console.Write("Enter array row size: ");
        int row = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter array column size: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[row, column];
        int[,] matrix2 = new int[row, column];
        
        Console.WriteLine("Fill first matrix");
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("Enter number for index " + i + ","+ j + ": ");
                int value = Convert.ToInt32(Console.ReadLine());
                matrix1[i, j] = value;
            }
        }
        
        Console.WriteLine("Fill second matrix");
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("Enter number for index " + i + ","+ j + ": ");
                int value = Convert.ToInt32(Console.ReadLine());
                matrix2[i, j] = value;
            }
        }
        
        Console.WriteLine("Here is matrix view of multidimensional array");

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(j == column - 1 ? matrix1[i, j]+matrix2[i,j] :  (matrix1[i, j]+matrix2[i,j]) + ", " );
            }
            Console.WriteLine();
        }
        

    }
}