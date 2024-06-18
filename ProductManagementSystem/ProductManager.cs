using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class ProductManager
    { 
        public static void AddProduct(Product product)
        {
            DataStorage.products.Add(product);
            Console.WriteLine("\nProduct added successfully...");
        }

        public static void ViewProduct()
        {
            Console.WriteLine("\n-----------------All Products------------------");
            if (DataStorage.products.Count == 0)
            {
                Console.WriteLine("\n!!!Product list is empty!!!");
            }
            foreach (Product product in DataStorage.products)
            {
                Console.WriteLine($"\nProductId: {product.ID}\nProductName: {product.Name}\nProductDetails: {product.Description}\nManufacturedBy: {product.ManufacturedBy}\nPrice: {product.Price}\n");
            }
            Console.WriteLine("\n-----------------------------------------------");
        }

        public static void ViewSpecificProduct()
        {
            Console.WriteLine("\n---------------Filtered Products---------------");
            if (DataStorage.products.Count == 0)
            {
                Console.WriteLine("\n!!!Product list is empty!!!");
            }
            foreach (Product product in DataStorage.products)
            {
                if(product.Price > 1000)
                {
                    Console.WriteLine($"\nProductId: {product.ID}\nProductName: {product.Name}\nProductDetails: {product.Description}\nManufacturedBy: {product.ManufacturedBy}\nPrice: {product.Price}\n");
                }
            }
            Console.WriteLine("\n-----------------------------------------------");
        }

        public static void DeleteProduct()
        {
            DataStorage.products.Clear();
            Console.WriteLine("\nAll products are cleared...");
        }

    }
}
