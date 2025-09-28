namespace homework1.Homework5;

public class Task7
{
    public static void Main()
    /* პირობაში ეწერა, რომ ფუნქიცაში რომელშიც მასივს ვავსებთ მომხმარებელმა უნდა შეიწყვანოს მასივის ზომები და
     რადგან მეორე მასივში ამ ფუნქციის დახმარებით 2 მასივს ვიღებთ პარამეტრად ანუ 2ჯერ უნდა გავუშვათ და 
     შესაბამისად ზომის მითითებაც 2ჯერ გვიწევს.
    */
    {
        addMatrices(fillMatrix(), fillMatrix());

    }

    public static void print(int[,] matrix)
    {
        Console.WriteLine("Here is sum of matrices");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(j == matrix.GetLength(1) ? matrix[i, j] + ", " : matrix[i, j]);
            }
            
            Console.WriteLine();
        }
    }


    public static int[,] addMatrices(int[,] matrice1, int[,] matrice2)
    {   
        int rows = matrice1.GetLength(0);
        int cols = matrice1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrice1[i, j] + matrice2[i, j];
            }
        }
        print(result);
        return result;
    }

    public static int[,] fillMatrix()
    {
        Console.Write("Enter count of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter count of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter integer for index {i},{j}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                matrix[i, j] = number;
            }
        }
        return matrix;
    }
}