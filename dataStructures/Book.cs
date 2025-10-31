namespace homework1.dataStructures;

public enum Genre { Comedy, Horror, Romance, Fantasy}
public class Book 
{
    public string? AuthorFullName { get; set; }
    public string? Title { get; set; }
    public int Year { get; set; }
    public Genre Genre { get; set; }
    public string? Isbn { get; set; }

    public Book(string authorFullName, string title, int year, Genre genre, string isbn)
    {
        AuthorFullName = authorFullName;
        Title = title;
        Year = year;
        Genre = genre;
        Isbn = isbn;
    }

    public static void main()
    {
        List<Book> books = new List<Book>
        {
            new Book("George Orwell", "1984", 1949, Genre.Comedy,"9780451524935"),
            new Book("Isaac Asimov", "Foundation", 1951,  Genre.Horror, "9780553293357"),
            new Book("Agatha Christie", "Murder on the Orient Express", 1934, Genre.Romance, "9780062693662"),
            new Book("J.K. Rowling", "Harry Potter and the Philosopher's Stone", 1997, Genre.Fantasy, "9780747532699")
        };

        Console.WriteLine("Sorted by Author : ");
        books.Sort(new SortByAuthorFullName());
        books.ForEach(b => Console.WriteLine(b.AuthorFullName));

        Console.WriteLine("\n Sorted by Year : ");
        books.Sort(new SortByYear());
        books.ForEach(b => Console.WriteLine(b.Year));

        Console.WriteLine("\n Sorted by Title : ");
        books.Sort(new SortByTitle());
        books.ForEach(b => Console.WriteLine(b.Title));
    }
    
}
