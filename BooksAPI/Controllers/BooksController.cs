using BooksAPI.Repository;
using BooksAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            var addBook = _bookServices.AddBook(book);
            return Ok(addBook);
        }

        [HttpGet]
        public IActionResult GetAllBook()
        {
            var allBooks = _bookServices.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpPut("{isbn}")]
        public IActionResult UpdateBook(Guid isbn, Book book)
        {
            var bookExist = _bookServices.UpdateBook(isbn, book);
            if (bookExist != null)
            {
                return Ok(bookExist);
            }
            return NotFound($"!!!Book with isbn {isbn} not found!!!");
        }

        [HttpDelete("{isbn}")]
        public IActionResult DeleteBook(Guid isbn)
        {
            var existBook = _bookServices.DeleteBook(isbn);
            if (existBook != null)
            {
                return Ok(existBook);
            }
            return NotFound($"!!!Book with isbn {isbn} not found!!!");
        }

        [HttpGet("maxprice")]
        public IActionResult MaxPrice()
        {
            var maxAmountBook = _bookServices.SearchBook(x => x.Amount == _bookServices.GetAllBooks().Max(book => book.Amount)).FirstOrDefault();
            if(maxAmountBook != null)
            {
                return Ok($"Max Price : {maxAmountBook.Amount}");
            }
            return NotFound("Book not found");
        }

        [HttpGet("maxminbook")]
        public IActionResult MaxMinPriceBook()
        {
            var maxAmountBook = _bookServices.SearchBook(x => x.Amount == _bookServices.GetAllBooks().Max(book => book.Amount)).FirstOrDefault();
            var minAmountBook = _bookServices.SearchBook(x => x.Amount == _bookServices.GetAllBooks().Min(book => book.Amount)).FirstOrDefault();
            if(maxAmountBook != null || minAmountBook != null)
            {
                return Ok(new
                {
                    MaxPriceBook = new { maxAmountBook.Title, maxAmountBook.Amount },
                    MinPriceBook = new { minAmountBook.Title, minAmountBook.Amount }
                });
            }
            return NotFound("Book not found");
        }

        [HttpGet("filter/{character}")]
        public IActionResult FilterBook(char character)
        {
            var filteredBook = _bookServices.SearchBook(x => x.Title.StartsWith(character.ToString(), StringComparison.OrdinalIgnoreCase));
            if(filteredBook != null)
            {
                return Ok(filteredBook);
            }
            return NotFound("Book not found");
        }
        
    }
}
