namespace homework1.homework4;

public class Task8
{
    public static void Main()
    {
        int[,] arr = new int[, ]
        {
            {0,1,1,1,1,1,1,1},
            {0,0,1,1,1,1,1,1},
            {0,0,0,1,1,1,1,1},
            {0,0,0,0,1,1,1,1},
            {0,0,0,0,0,1,1,1},  
            {0,0,0,0,0,0,1,1},
            {0,0,0,0,0,0,0,1},
            {0,0,0,0,0,0,0,0},
        };
        
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows/2; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[rows - i - 1, j];
                arr[rows - i - 1, j] = temp;
            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        //for jagged array 
        int[][] arr1 = new int[][]
        {
            new int[] {0,1,1,1,1,1,1,1},
            new int[] {0,0,1,1,1,1,1,1},
            new int[] {0,0,0,1,1,1,1,1},
            new int[] {0,0,0,0,1,1,1,1},
            new int[] {0,0,0,0,0,1,1,1},  
            new int[] {0,0,0,0,0,0,1,1},
            new int[] {0,0,0,0,0,0,0,1},
            new int[] {0,0,0,0,0,0,0,0},
        };

        for (int i = 0; i < rows/2; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = arr1[i][j];
                arr1[i][j] = arr1[rows - i - 1][j];
                arr1[rows - i - 1][j] = temp;
            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr1[i][j] + " ");
            }
            Console.WriteLine();
        }
        
        
    }
}