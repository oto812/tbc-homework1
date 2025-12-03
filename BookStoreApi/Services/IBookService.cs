using BookStoreApi.Models;

namespace BookStoreApi.Services;

public interface IBookService
{
    IEnumerable<Book> GetBooks();
    Book? GetBook(int id);
}