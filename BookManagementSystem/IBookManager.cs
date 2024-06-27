using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal interface IBookManager
    {
        void AddBook(Book book);
        void ViewAllBook();
        List<Book> SearchBook(Predicate<Book> predicate);
        void DeleteBookById(Predicate<Book> predicate);
    }
}
