using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class BookManager : IBookManager
    {
        public readonly List<Book> BookList = new List<Book>();

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }

        public void ViewAllBook()
        {
            if (BookList.Count == 0)
            {
                Console.WriteLine("\nBookList are already empty!!!");
            }
            foreach (Book book in BookList)
            {
                Console.WriteLine($"\nBookId: {book.Id}\nBookTitle: {book.Title}\nBookAuthor: {book.Author}\nBookRating: {book.Rating}\nBookPrice: {book.Price} Rs.");
            }
        }

        public List<Book> SearchBook(Predicate<Book> searchBookPredicate)
        {
            return BookList.FindAll(searchBookPredicate);
        }

        public void DeleteBookById(Predicate<Book> deleteBookByIdPredicate)
        {
            if (BookList.Count == 0)
            {
                Console.WriteLine("\nBookList are already empty!!!");
            }
            var book = BookList.Find(deleteBookByIdPredicate);
            if (book != null)
            {
                BookList.Remove(book);
                Console.WriteLine("\nBook deleted successfully");
            }
            else
            {
                Console.WriteLine("\nBook does not exist");
            }
        }
    }
}
