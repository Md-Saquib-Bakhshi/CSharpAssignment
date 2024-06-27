using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class BookServices
    {
        private readonly IBookManager _bookManager;

        public BookServices(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public void MainMenu()
        {
            while (true)
            {
                Console.Write("\nEnter\n 1 for AddBook\n 2 for ViewAllBook\n 3 for SearchBookByAuthor\n 4 for SearchBookByRating\n 5 for DeleteBookById\n 6 for Exit: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n!!!Select option from the given choice!!!");
                    return;
                }
                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        _bookManager.ViewAllBook();
                        break;
                    case 3:
                        SearchBookByAuthor();
                        break;
                    case 4:
                        SearchBookByRating();
                        break;
                    case 5:
                        DeleteBookById();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("\n!!!Invalid Choice!!!");
                        break;
                }
            }
        }

        private void AddBook()
        {
            Console.Write("\nEnter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();

            //Validation for Title nd Author
            var existingBook = _bookManager.SearchBook(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
            if (existingBook.Count > 0)
            {
                Console.WriteLine("\nBook already exist.");
                return;
            }

            Console.Write("Enter Book Rating(0 - 5.0): ");
            if (!double.TryParse(Console.ReadLine(), out double rating) || rating < 0 || rating > 5)
            {
                Console.WriteLine("\nInvalid rating.");
                return;
            }

            Console.Write("Enter Book Price: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
            {
                Console.WriteLine("\nInvalid price.");
                return;
            }

            //Validation
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("\nAll fields are required*");
                return;
            }

            Book book = new Book(title, author, rating, price);
            _bookManager.AddBook(book);
            Console.WriteLine("\nBook added successfully");
        }

        private void SearchBookByAuthor()
        {
            Console.Write("\nEnter Author to search: ");
            string author = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("\nField are required*");
                return;
            }

            var books = _bookManager.SearchBook(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

            if (books.Count == 0)
            {
                Console.WriteLine("\nNo books found by this author.");
                return;
            }
            foreach (var book in books)
            {
                PrintBookDetails(book);
            }
        }

        private void SearchBookByRating()
        {
            Console.Write("\nEnter Rating to search: ");
            if (!double.TryParse(Console.ReadLine(), out double rating) || rating < 0 || rating > 5)
            {
                Console.WriteLine("\nInvalid rating.");
                return;
            }
            var books = _bookManager.SearchBook(b => b.Rating.Equals(rating));
            if (books.Count == 0)
            {
                Console.WriteLine("\nNo books found for this rating.");
                return;
            }
            foreach (var book in books)
            {
                PrintBookDetails(book);
            }
        }

        private void DeleteBookById()
        {
            Console.Write("\nEnter Id to delete: ");
            if(!int.TryParse(Console.ReadLine(), out int id) || id < 0)
            {
                Console.WriteLine("\nInvalid id.");
                return;
            }
            _bookManager.DeleteBookById(b => b.Id == id);
        }

        private void PrintBookDetails(Book book)
        {
            Console.WriteLine($"\nBookId: {book.Id}\nBookTitle: {book.Title}\nBookAuthor: {book.Author}\nBookRating: {book.Rating}\nBookPrice: {book.Price} Rs.");
        }

    }
}
