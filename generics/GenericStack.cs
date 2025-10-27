namespace homework1.generics;

public class GenericStack<T>
{
    private List<T> _list = new List<T>();

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T item = _list[_list.Count - 1];
        _list.RemoveAt(_list.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _list[_list.Count - 1];
    }
    
}