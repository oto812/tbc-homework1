namespace homework1.midtermTask3;

public class TicTacToe
{
    public static void main()
    {
        bool GameEnded = false;
        int playerTurn = 0;
        Console.Write("Pleas enter number of rows : ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Pleas enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        string[,] board = new string[rows, cols];
        DrawBoard(board);
        while (!GameEnded)
        {
            int rowInput;
            int colInput;
            while (true)
            {
                Console.Write(playerTurn % 2 == 0 ? "Player 1 enter you row: " : "Player 2 enter you row: ");
                rowInput = Convert.ToInt32(Console.ReadLine());
                if (rowInput >= board.GetLength(0) || rowInput < 0)
                {
                    Console.WriteLine($"Invalid input enter between 0 and {board.GetLength(0) - 1}");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write(playerTurn % 2 == 0 ? "Player 1 enter you Column: " : "Player 2 enter you Column");
                colInput = Convert.ToInt32(Console.ReadLine());
                if (colInput >= board.GetLength(1) || colInput < 0)
                {
                    Console.WriteLine($"Invalid input enter between 0 and {board.GetLength(1) - 1}");
                }
                else
                {
                    break;
                }
            }
            
            
            board[rowInput, colInput] = playerTurn % 2 == 0 ? "X" : "O";
            playerTurn++;
            DrawBoard(board);
            
            if (CheckforEnd(board))
            {
                GameEnded = true;
                Console.WriteLine($"Game Over");
            }
            


        }
    }

    public static void DrawBoard(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int m = 0; m < board.GetLength(1); m++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
            
            for (int j = 0; j < board.GetLength(1); j++)
            {
                
                Console.Write($"| {board[i,j]} |");
                
            }
            Console.WriteLine();
        }
    }

    public static bool CheckforEnd(string[,] board)
    {
        if (RowCheck(board))
        {
            return true;
        }

        return false;

    }

    public static bool RowCheck(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            string startRow = board[i, 0];
            if (startRow != "X" && startRow != "O")
            {
                continue;
            }
            for (int j = 0; j < board.GetLength(1); j++)
            {
                
                if (board[i, j] == startRow )
                {
                    if(j == board.GetLength(1) - 1) return true;
                }else
                {
                    break;
                }
            }
        }
        return false;
    }

    public static bool ColCheck(string[,] board)
    {
        for (int i = 0; i < board.GetLength(1); i++)
        {
            
            for (int j = 0; j < board.GetLength(0); j++)
            {
                string startCol = board[j, 0];
                if (startCol == "")
                {
                    continue;
                }
                if (board[j, i] == startCol )
                {
                    if(i == board.GetLength(0) - 1) return true;
                }
                else
                {
                    break;
                }
            }
        }
        return false;
    }

    public static bool DiagonalCheck(string[,] board)
    {
        string start = board[0, 0];
        int row = 1;
        int col = 1;
        int size = board.GetLength(0);

        while (row < size)
        {
            if (start != "X" && start != "O")
            {
                break;
            }
            if (board[row, col] == start)
            {
                if(row == size - 1) return true;
            }else
            {
                break;
            }

            row++;
            col++;
        }
        start = board[size - 1,size - 1];
        row = size - 1;
        col = size - 1;
        while (row >= 0)
        {
            if (start != "X" && start != "O")
            {
                break;
            }
            if (board[row, col] == start)
            {
                if(row == 0) return true;
            }else
            {
                break;
            }

            row--;
            col--;
        }

        return false;

    }
}