using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3_Company_Hierarchy.Interfaces;

namespace Problem3_Company_Hierarchy
{
    class Sale:ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, decimal price, DateTime date)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = date;
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price of the sale must be non-negative");
                }
                this.price = value;
            }
        }

        public DateTime Date { get; set; }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The product name must be non-empty");
                }
                this.productName = value;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + "\n" + "Product name: " + this.ProductName + "\n" + "Product price: " +
                   this.Price + "\n" + "Product sale date: " + this.Date + "\n";
        }
    }
}
