namespace homework1.dataStructures;

public class SortByYear : IComparer<Book>

{
    public int Compare(Book? x, Book? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException("Can't compare nulls.");

        return x.Year.CompareTo(y.Year);
    }
}