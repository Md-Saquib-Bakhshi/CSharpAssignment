using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagementSystem
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
                        Thread thread = new Thread(() =>
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                  Loading JoMart Application...                                                                  ");
                            Thread.Sleep(3000);
                        });
                        thread.Start();
                        thread.Join();
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
                Console.WriteLine($"\n{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
        }
    }
}
