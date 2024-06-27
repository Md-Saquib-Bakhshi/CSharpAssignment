using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class Book
    {
        private static int AutoIncremented = 100;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, double rating, double price)
        {
            Id = ++AutoIncremented;
            Title = title;
            Author = author;
            Rating = rating;
            Price = price;
        }
    }
}
