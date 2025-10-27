namespace homework1.generics;

public class GenericQueue<T>
{
    private List<T> _list = new List<T>();
    

    public void Enqueue(T item)
    {
        _list.Add(item);
    }

    /* it takes O(n) using lists we can optimize it to O(1)
        using linked lists */
    public T Dequeue()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T res = _list[0];
        _list.RemoveAt(0);
        return res;
    }

    public T Peek()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        } 
        return _list[0];
    }
    
    
}