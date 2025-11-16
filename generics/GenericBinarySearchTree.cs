namespace homework1.generics;

public class GenericBinarySearchTree<T> where T : IComparable<T>
{
    private Node<T>? _root;

    public void Insert(T value)
    {
        _root = InsertHelper(_root, value);
    }

    private Node<T> InsertHelper(Node<T>? root, T value)
    {
        if (root == null)
            return new Node<T>(value);

        int comp = value.CompareTo(root.Val);

        if (comp < 0)
            root.Left = InsertHelper(root.Left, value);
        else if (comp > 0)
            root.Right = InsertHelper(root.Right, value);

        return root;
    }

    public Node<T>? Search(T value)
    {
        return SearchHelper(_root, value);
    }

    private Node<T>? SearchHelper(Node<T>? root, T value)
    {
        if (root == null)
            return null;

        int comp = value.CompareTo(root.Val);

        if (comp == 0)
            return root;
        else if (comp < 0)
            return SearchHelper(root.Left, value);
        else
            return SearchHelper(root.Right, value);
    }
}
