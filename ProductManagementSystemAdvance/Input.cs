using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemAdvance
{
    internal class Input
    {
        public static void InputMenu()
        {
            try
            {
                Console.Write("\nEnter\n 1 for Start\n 2 for Quit: ");
                if (!int.TryParse(Console.ReadLine(), out int choice)){
                    throw new FormatException("!!!Input must be an integer value!!!");
                }
                switch (choice)
                {
                    case 1:
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Menu();
                        break;
                    case 2:
                        Action<string> exitDelegate = msg => Console.WriteLine(msg) ;
                        exitDelegate("\nThankyou come again...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("!!!Invalid Choice!!!");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"\nFormatException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nUnhadledException: {e.Message}");
            }
        }
    }
}
