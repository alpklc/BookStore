namespace WebApi;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int GenreId { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
}