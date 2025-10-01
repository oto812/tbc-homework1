namespace homework1.homework6;

public class Task3
{
    public static void Main()
    {
        reverse("hello");
        
    }
    
    public static void reverse(string str)
    {
        for (int i =  str.Length - 1; i >= 0; i--)
        {
            Console.Write(i == 0 ? $"{str[i]}"  : $"{str[i]} " );
        }
    }
}