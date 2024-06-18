using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemAdvance
{
    public delegate void StartHandler();
    internal class MainMenu
    {
        public MainMenu()
        {
            StartHandler startHandler = null;
            startHandler += UserInterface;
            startHandler += WelcomeMessage;
            startHandler();
        }
        public void Menu()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("\n------------------");
                    Console.WriteLine($"Total Product: {DataStorage.products.Count}  |");
                    Console.WriteLine("------------------\n");
                    Console.Write("\nEnter\n 1 for AddProduct\n 2 for ViewProduct\n 3 for ViewSpecificProduct\n 4 for RemoveAllProduct\n 5 for exit: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        throw new FormatException("!!!Input must be an integer value!!!");
                    }
                    switch (choice)
                    {
                        case 1:
                            ProductForm form = new ProductForm();
                            form.ProductDetail();
                            break;
                        case 2:
                            ProductManager.ViewProduct();
                            break;
                        case 3:
                            Predicate<Product> filteredProductDelegate = FilteredProduct;
                            ProductManager.ViewSpecificProduct(filteredProductDelegate);
                            break;
                        case 4:
                            ProductManager.DeleteProduct();
                            break;
                        case 5:
                            ApplicationsDelegate applicationsDelegate = ApplicationInterface.ApplicationsInterface;
                            applicationsDelegate();
                            ApplicationInterface.FirstInterface();
                            Input.InputMenu();
                            break;
                        default:
                            Console.WriteLine("!!!Invalid Input!!!");
                            break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"\nFormatException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nUnhandledException: {e.Message}");
            }
        }

        static bool FilteredProduct(Product product)
        {
            return product.Price > 1000;
        }

        //Delegates
        public void UserInterface()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("\n********************************************************************!!! Welcome User !!!********************************************************************\n");
           
        }
    }
}
