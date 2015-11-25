using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_PC_Catalog
{
    class Component
    {
        private string name;
        private double price;
        private string details;

        public Component(string name, double price, string details)
        {
            Name = name;
            Price = price;
            Details = details;
        }

        public Component(string name, double price) : this(name, price, null)
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The value must be non-empty","Component name");
                }
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value must be non-empty","Component price");
                }
                price = value;
            }
        }

        public string Details
        {
            get { return details; }
            set
            {
                if (value=="")
                {
                    throw new ArgumentException("The value must be non-empty", "Component detail");
                }
                details = value;
            }
        }
    }
}
