namespace homework1.dataStructures;

public class SortByTitle : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException("Can't compare nulls.");
        
        return string.Compare(x.Title,y.Title,StringComparison.Ordinal);
    }
}