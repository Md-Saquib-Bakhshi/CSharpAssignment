using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class ProductForm
    {
        public void ProductDetail()
        {
            try
            {
                Console.WriteLine("\n********* Product Form *********");
                Console.WriteLine();

                //Taking Inputs
                Console.Write("Enter ProductName: ");
                string name = Console.ReadLine();
                Console.Write("Enter Description: ");
                string description = Console.ReadLine();
                Console.Write("Enter ManufacturedBy: ");
                string manufacturedBy = Console.ReadLine();
                Console.Write("Enter Price: ");
                if (!double.TryParse(Console.ReadLine(), out double price))
                {
                    throw new FormatException("!!!Price must be double value.!!!");
                }
                Console.WriteLine();
                Console.WriteLine("**********************************");

                //Validation
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(manufacturedBy))
                {
                    throw new ArgumentException("!!!All fields are required*!!!");
                }

                if (!Validator.PriceValidator(price))
                {
                    throw new InvalidPriceException("\n!!!Price must be a positive number.!!!");
                }

                // Check if the product already exists
                if (DataStorage.products.Any(p => p.Name.Equals(name)))
                {
                    Console.WriteLine("\n!!!Product with this name already exists.!!!");
                    return;
                }
                Product product = new Product(name, description, manufacturedBy, price);
                ProductManager.AddProduct(product);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"FormatException: {e.Message}");
            }
            catch (InvalidPriceException e)
            {
                Console.WriteLine($"InvalidPriceException: {e.Message}");
            }
        }
    }
}
