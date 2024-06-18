using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagementSystem
{
    internal class Mobile
    {
        private static int autoID = 3000;

        private int id;
        private string name;
        private string description;
        private string manufacturedBy;
        private double price;

        public int ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToLower();
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string ManufacturedBy
        {
            get
            {
                return manufacturedBy;
            }
            set
            {
                manufacturedBy = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n!!!Price must be a positive value*!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                price = value;
            }
        }

        public Mobile(string name, string description, string manufacturedBy, double price)
        {
            ID = ++autoID;
            Name = name;
            Description = description;
            ManufacturedBy = manufacturedBy;
            Price = price;
        }
    }
}
