namespace homework1.homework6;

public class Task4
{
    public static void Main()
    {
        printCountWords("World   hello abc ");
        
    }

    public static int countWords(string text)
    {
        int counter = 0;
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "")
            {
                counter++;
            }
        }

        return counter;

    }
    public static void printCountWords(string text)
    {
        int counter = 0;
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "")
            {
                counter++;
            }
        }

        Console.WriteLine(counter);

    }
    
    /*
     * shorter version:
     *  return/Console.write (input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
    */
     
}