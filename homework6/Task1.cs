using System.Text;

namespace homework1.homework6;

public class Task1
{
    public static void Main()
    {
        vowelOrCon("Hello, world!", false);
        
    }

    public static int vowelOrCon(string input, bool countVowels = true)
    {
        StringBuilder printRes = new StringBuilder();
        string vowels = "aeiouAEIOU";
        int result = 0;
        foreach (char c in input)
        {
            if (countVowels)
            {
                // ✅ Count vowels only
                if (vowels.Contains(c))
                {
                    result++;
                    printRes.Append(c + " ");
                }
            }
            else
            {
                // ✅ Count consonants (letters that are not vowels)
                if (char.IsLetter(c) && !vowels.Contains(c))
                {
                    result++;
                    printRes.Append(c + " ");
                }
            }
        }

        Console.WriteLine($"Vowel count is {result}");
        Console.Write(countVowels ? "Vowels : " : "Consonants : ");
        for (int i = 0; i < printRes.Length; i++)
        {
            Console.Write(printRes[i]);
        }
        
        return result;
    }
}