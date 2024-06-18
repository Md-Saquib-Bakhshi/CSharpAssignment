using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagementSystem
{
    internal class MobileForm
    {
        public void MobileDetail()
        {
            Console.WriteLine("\n******************************** Mobile Add Form ********************************");
            Console.WriteLine();

            //Taking Inputs
            Console.Write("Enter MobileName: ");
            string name = Console.ReadLine();

            //While Running checking name exist or not using thread
            bool nameExists = false;
            Thread nameAvailabilityCheckingThread = new Thread(() =>
            {
                if (DataStorage.mobiles.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) != null)
                {
                    nameExists = true;
                }
            });
            nameAvailabilityCheckingThread.Start();
            nameAvailabilityCheckingThread.Join();
            if (nameExists)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n!!!{name} already exists in Product list!!!");
                Console.ForegroundColor = ConsoleColor.Black;
                return;
            }
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            Console.Write("Enter ManufacturedBy: ");
            string manufacturedBy = Console.ReadLine();
            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************");

            //Validation
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(manufacturedBy))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!!!All fields are required*!!!");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Mobile mobile = new Mobile(name, description, manufacturedBy, price);
            DataStorage.AddMobile(mobile);
        }
    }
}
