using BookStoreApi.Models;

namespace BookStoreApi.Services;

public class BookService : IBookService
{
    private readonly List<Book> _books;

    public BookService()
    {
        _books = new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", YearPublished = 2008 },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", YearPublished = 1999 },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", YearPublished = 1994 }
        };
    }

    public IEnumerable<Book> GetBooks() => _books;

    public Book? GetBook(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }
}