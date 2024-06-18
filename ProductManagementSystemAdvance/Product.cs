using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemAdvance
{
    internal class Product
    {
        private static int autoID = 1000;

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
                price = value;
            }
        }

        public Product(string name, string description, string manufacturedBy, double price)
        {
            ID = ++autoID;
            Name = name;
            Description = description;
            ManufacturedBy = manufacturedBy;
            Price = price;
        }
    }
}
