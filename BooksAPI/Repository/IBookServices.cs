using BooksAPI.Models;
namespace BooksAPI.Repository
{
    public interface IBookServices
    {
        Book AddBook(Book book);
        IEnumerable<Book> GetAllBooks();
        Book UpdateBook(Guid isbn, Book book);
        bool DeleteBook(Guid isbn);
        IEnumerable<Book> SearchBook(Predicate<Book> searchBookPredicate);
    }
}
