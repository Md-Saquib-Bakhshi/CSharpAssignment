using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagementSystem
{
    internal class DataStorage
    {
        public static List<Mobile> mobiles = new List<Mobile>();


        public static void AddMobile(Mobile mobile)
        {
            mobiles.Add(mobile);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n{mobile.Name} added successfully...");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void ViewAllMobile()
        {
            Console.WriteLine("\n---------------------------------- All Mobiles -------------------------------------");
            if (mobiles.Count == 0)
            {
                Console.WriteLine("\n!!!Mobile list is empty!!!");
            }
            foreach (Mobile mobile in DataStorage.mobiles)
            {
                Console.WriteLine($"\nMobileId: {mobile.ID}\nMobileName: {mobile.Name}\nMobileDetails: {mobile.Description}\nManufacturedBy: {mobile.ManufacturedBy}\nPrice: {mobile.Price}\n");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");
        }

        public static void SearchLowBudgetMobile(Predicate<Mobile> predicate)
        {
            Console.WriteLine("\n--------------------------------- Filtered Products ---------------------------------");
            Console.WriteLine("\n---------------------- Mobile having less price than max price ----------------------");
            if (mobiles.Count == 0)
            {
                Console.WriteLine("\n!!!Product list is empty!!!");
            }
            foreach (Mobile mobile in DataStorage.mobiles)
            {
                if (predicate(mobile))
                {
                    Console.WriteLine($"\nProductId: {mobile.ID}\nProductName: {mobile.Name}\nProductDetails: {mobile.Description}\nManufacturedBy: {mobile.ManufacturedBy}\nPrice: {mobile.Price}\n");
                }
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");
        }

        public static void SearchByManufacturer()
        {

            Console.WriteLine("\n--------------------------------- Filtered Products ---------------------------------");
            Console.WriteLine("\n------------------------------- Search by manufacturer  -----------------------------");
            if (mobiles.Count == 0)
            {
                Console.WriteLine("\n!!!Product list is empty!!!");
            }
            Console.Write("Enter Manufacturer Name to filter: ");
            string manufacturerName = Console.ReadLine();
            foreach (Mobile mobile in DataStorage.mobiles)
            {
                if (mobile.ManufacturedBy.Equals(manufacturerName))
                {
                    Console.WriteLine($"\nProductId: {mobile.ID}\nProductName: {mobile.Name}\nProductDetails: {mobile.Description}\nManufacturedBy: {mobile.ManufacturedBy}\nPrice: {mobile.Price}\n");
                }
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");
        }

        public static void SearchIntermediateBudgetMobile(Predicate<Mobile> predicate)
        {
            Console.WriteLine("\n--------------------------------- Filtered Products ---------------------------------");
            Console.WriteLine("\n------------ Mobile having price greater than min and less than max price -----------");
            if (mobiles.Count == 0)
            {
                Console.WriteLine("\n!!!Product list is empty!!!");
            }
            foreach (Mobile mobile in DataStorage.mobiles)
            {
                if (predicate(mobile))
                {
                    Console.WriteLine($"\nProductId: {mobile.ID}\nProductName: {mobile.Name}\nProductDetails: {mobile.Description}\nManufacturedBy: {mobile.ManufacturedBy}\nPrice: {mobile.Price}\n");
                }
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");
        }

        public static void RemoveMobile()
        {
            var mobilesToRemove = DataStorage.mobiles.Where(m => m.Price > MainMenu.minPrice && m.Price < MainMenu.maxPrice).ToList();

            foreach (var mobile in mobilesToRemove)
            {
                DataStorage.mobiles.Remove(mobile);
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nMobiles removed successfully.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
