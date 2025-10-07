using System.Runtime.CompilerServices;

namespace homework1.Recursion;

public class Task5
{
    public static void main()
    {
        Console.WriteLine(isPalindrome("ABBBA"));
        Console.WriteLine(isPalindrome("ABBCA"));
        Console.WriteLine(isPalindromeTail("ABBBA"));
        Console.WriteLine(isPalindromeTail("ABBCA"));

    }

    public static bool isPalindrome(string s)
    {
        if (s.Length <= 1) return true;
        return helper(s, 0);
    }

    public static bool helper(string s, int index)
    {
        int rightIndex = s.Length - index - 1;

        if (index >= rightIndex) return true;
        if (s[index] != s[rightIndex]) return false;
        //redundant check but since we want non tail recursive solution too :D 
        return s[index] == s[rightIndex] && helper(s, index + 1);
    }
    
    // tail recursive

    public static bool isPalindromeTail(string s)
    {
        if (s.Length <= 1) return true;
        return helperTail(s, 0, s.Length - 1);
    }

    public static bool helperTail(string s, int left, int right)
    {
        if (left >= right) return true;
       
        if (s[left] != s[right]) return false;
        

        return helperTail(s, left + 1, right - 1);
    }
}