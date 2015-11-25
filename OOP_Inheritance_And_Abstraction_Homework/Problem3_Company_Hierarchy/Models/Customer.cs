using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy.Models
{
    class Customer:Person
    {
        public decimal totalSpent;
        public Customer(string id, string firstName, string lastName,decimal totalSpent) : base(id, firstName, lastName)
        {
            this.TotalSpent = totalSpent;
        }

        public decimal TotalSpent
        {
            get { return this.totalSpent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The amount spend by the costumer must be non-negative");
                }
                this.totalSpent = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+ "Total amount of money spent: "+this.TotalSpent+"\n";
        }
    }
}
