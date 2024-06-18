using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class Input
    {
        public void MainMenu()
        {
            try
            {
                while (true)
                {
                    Console.Write("\nEnter\n 1 for AddProduct\n 2 for ViewProduct\n 3 for ViewSpecificProduct\n 4 for RemoveAllProduct\n 5 for exit: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        throw new FormatException("!!!Choice must be a integer value!!!");
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
                            ProductManager.ViewSpecificProduct();
                            break;
                        case 4:
                            ProductManager.DeleteProduct();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("!!!Invalid Input!!!");
                            break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"FormatException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"UnhandledException: {e.Message}");
            }
        }
    }
}
