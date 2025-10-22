namespace homework1.oop2and3;

public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static int CharCount(this string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }

    public static bool StartsOrEndsWith(this string str, string substring)
    {
        if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(substring))
            return false;
        return str.StartsWith(substring) || str.EndsWith(substring);
    }
    
}