using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    [HttpGet]
    public IActionResult GetBooks()
    {
        return Ok(_bookService.GetBooks());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetBook(int id)
    {
        var book = _bookService.GetBook(id);

        if (book == null)
            return NotFound(); 

        return Ok(book);
    }
}