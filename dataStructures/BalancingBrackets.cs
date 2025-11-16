namespace homework1.dataStructures;

public class BalancingBrackets
{

    public static void main()
    {
        Console.WriteLine(AreBalancedBrackets(""));
        List<Book> books = new List<Book>();
        
    }

    public static bool AreBalancedBrackets(string str)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in str)
        {
            if(stack.Count == 0 && (ch == '}' || ch == ']' || ch == ')')) return false; 
            switch (ch)
            {
                case ')':
                    if (stack.Pop() != '(') return false;
                    break;
                case ']':
                    if(stack.Pop() != '[') return false;
                    break;
                case '}':
                    if (stack.Pop() != '{') return false;
                    break;
                default:
                    stack.Push(ch);
                    break;
            }
        }
        return stack.Count == 0;
    }
}