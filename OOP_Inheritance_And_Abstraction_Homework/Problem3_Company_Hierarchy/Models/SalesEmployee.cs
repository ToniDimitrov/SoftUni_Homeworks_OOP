using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3_Company_Hierarchy.Interfaces;

namespace Problem3_Company_Hierarchy
{
    class SalesEmployee:RegularEmployee,ISalesEmployee
    {
        public HashSet<Sale> Sales { get; set; }
        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string department,HashSet<Sale> sales ) : base(id, firstName, lastName, salary, department)
        {
            this.Sales = new HashSet<Sale>(sales);
        }

        public override string ToString()
        {

            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine("Products: ");
            foreach (var sale in Sales)
            {
                result.AppendLine("\tProject name: " + sale.ProductName);
                result.AppendLine("\tProject start date: " + sale.Price);
                result.AppendLine("\tProject state: " + sale.Date + "\n");
            }
            return result.ToString();
        }
    }
}
