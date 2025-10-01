namespace homework1.homework6;

public class Task5
{
    public static void Main()
    {
        string test = "Hello 1! ";
        
        printSummary(countLetters(test), countdigits(test),test);
    }

    public static int countLetters(string text)
    {
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                counter++;
            }
        }

        return counter;
    }
    
    public static int countdigits(string text)
    {
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]))
            {
                counter++;
            }
        }

        return counter;
    }

    public static void printSummary(int charCount, int digitCount, string text)
    {
        Console.WriteLine($"\"{text}\" -> Letters: {charCount}, Numbers: {digitCount}, Others: {text.Length-charCount-digitCount}");
    }
   
}