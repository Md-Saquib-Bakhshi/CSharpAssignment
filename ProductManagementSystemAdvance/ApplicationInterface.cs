using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemAdvance
{
    public delegate void ApplicationsDelegate();
    internal class ApplicationInterface
    {
        public static void FirstInterface()
        {
            Console.WriteLine("\n\n**************************************************************** Product Management System *****************************************************************\n\n");
            Console.WriteLine("\n                                                             Welcome to Product Management System                                     \n");
            Console.WriteLine("\n                                                             Start                           Quit                                     \n");
            Console.WriteLine("\n\n************************************************************************************************************************************************************\n\n");
        }

        //Delegate 
        public static void ApplicationsInterface()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
