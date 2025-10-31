namespace homework1.dataStructures;

public class SortByAuthorFullName : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException("Can't compare nulls.");
        
        return string.Compare(x.AuthorFullName,y.AuthorFullName,StringComparison.Ordinal);
    }
}