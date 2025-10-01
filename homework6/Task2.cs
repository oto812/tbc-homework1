namespace homework1.homework6;

public class Task2
{
    public static void Main()
    {
        reverse("hello");
        
    }

    public static void reverse(string str)
    {
        for (int i =  str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }
}