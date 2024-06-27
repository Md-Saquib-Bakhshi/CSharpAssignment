namespace BooksAPI.Models
{
    public class Book
    {
        public Guid ISBN { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Amount { get; set; }
    }
}
