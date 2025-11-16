namespace homework1.generics;

public class Node<T>
{
    public T Val;
    public Node<T>? Left;
    public Node<T>? Right;

    public Node(T val)
    {
        Val = val;
    }
    
   
}