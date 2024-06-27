using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagementSystem
{
    public delegate void StartHandler();

    internal class MainMenu
    {
        public static double maxPrice = DataStorage.mobiles.Max(x => x.Price);
        public static double minPrice = DataStorage.mobiles.Min(x => x.Price);
        
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
                    Console.Write("\nEnter\n 1 for AddMobile\n 2 for ViewAllMobile\n 3 for SearchLowBudgetMobile (Price less than max price)\n 4 for SearchByManufacturer\n 5 for SearchIntermediateBudgetMobile (Price more than min price & less than max price)\n 6 for RemoveMobile (Remove all except min price & max price mobile)\n 7 for exit: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        throw new FormatException("\n!!!Choose from the given options!!!");
                    }
                    switch (choice)
                    {
                        case 1:
                            MobileForm mobileForm = new MobileForm();
                            mobileForm.MobileDetail();
                            break;
                        case 2:
                            DataStorage.ViewAllMobile();
                            break;
                        case 3:
                            Predicate<Mobile> filteredProductDelegate = FilteredProduct;
                            DataStorage.SearchLowBudgetMobile(filteredProductDelegate);
                            break;
                        case 4:
                            DataStorage.SearchByManufacturer();
                            break;
                        case 5:
                            Predicate<Mobile> filteredMobileDelegate = PriceGreaterLess;
                            DataStorage.SearchIntermediateBudgetMobile(filteredMobileDelegate);
                            break;
                        case 6:
                            DataStorage.RemoveMobile();
                            break;
                        case 7:
                            ApplicationsDelegate applicationsDelegate = ApplicationInterface.ApplicationsInterface;
                            applicationsDelegate();
                            ApplicationInterface.FirstInterface();
                            Input.InputMenu();
                            break;
                        default:
                            Console.WriteLine("!!!Invalid Choice!!!");
                            break;
                    }
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

        static bool FilteredProduct(Mobile mobile)
        {

            return mobile.Price < maxPrice;
        }

        static bool PriceGreaterLess(Mobile mobile)
        {

            return mobile.Price > minPrice && mobile.Price < maxPrice;
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
