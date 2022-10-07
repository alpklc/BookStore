using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BooksController : ControllerBase
{
    private static List<Book> BookList = new List<Book>() 
    {
        new Book {
            Id = 1,
            Title = "Lean Startup",
            GenreId = 1, // Personal Growth
            PageCount = 200,
            PublishDate = new DateTime(2001,06,12)
        },
        new Book {
            Id = 2,
            Title = "Herland",
            GenreId = 2, // Science Fiction
            PageCount = 250,
            PublishDate = new DateTime(2010,05,23)
        },
        new Book {
            Id = 3,
            Title = "Dune",
            GenreId = 2, // Science Fiction
            PageCount = 540,
            PublishDate = new DateTime(2002,12,21)
        }
    };

    [HttpGet]
    public List<Book> GetBooks()
    {
        var bookList = BookList.OrderBy(b => b.Id).ToList();
        return bookList;
    }

    [HttpGet("{id}")]
    public Book GetById(int id)
    {
        var book = BookList.Single(b => b.Id == id);
        return book;
    }

    [HttpGet]
    public Book Get(int id)
    {
        var book = BookList.Single(b => b.Id == id);
        return book;
    }
}