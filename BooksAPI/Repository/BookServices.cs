using BooksAPI.Models;
using BooksAPI.Repository;

namespace BooksAPI.Repository
{
    public class BookServices : IBookServices
    {
        private readonly List<Book> _bookList;

        public BookServices()
        {
            _bookList = new List<Book>()
            {
                new Book {Title = "Book One", Description = "Description for Book One", Author = "Author One", Amount = 100.00 },
                new Book {Title = "Book Two", Description = "Description for Book Two", Author = "Author Two", Amount = 200.00 },
                new Book {Title = "Book Three", Description = "Description for Book Three", Author = "Author Three", Amount = 300.00 },
                new Book {Title = "Book Four", Description = "Description for Book Four", Author = "Author Four", Amount = 400.00 },
                new Book {Title = "Book Five", Description = "Description for Book Five", Author = "Author Five", Amount = 500.00 }
            };
        }

        public Book AddBook(Book book)
        {
            _bookList.Add(book);
            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            if (_bookList.Count == 0)
            {
                Console.WriteLine("!!!Book list are already empty!!!");
            }
            return _bookList;
        }

        public Book UpdateBook(Guid isbn, Book book)
        {
            if (_bookList.Count == 0)
            {
                Console.WriteLine("!!!Book list are already empty!!!");
            }
            var bookExist = _bookList.FirstOrDefault(x => x.ISBN.Equals(isbn));
            if (bookExist != null)
            {
                bookExist.Title = book.Title;
                bookExist.Description = book.Description;
                bookExist.Author = book.Author;
                bookExist.Amount = book.Amount;
                return bookExist;
            }
            return null;
        }

        public void DeleteBook()
        {
            if (_bookList.Count == 0)
            {
                Console.WriteLine("!!!Book list are already empty!!!");
            }
            _bookList.Clear();
        }

        public IEnumerable<Book> SearchBook(Predicate<Book> searchBookPredicate)
        {
            return _bookList.FindAll(searchBookPredicate);
        }
    }
}
