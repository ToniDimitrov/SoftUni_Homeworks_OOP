using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3_Company_Hierarchy.Interfaces;

namespace Problem3_Company_Hierarchy
{
    class Manager:Employee,IManager
    {
        public HashSet<RegularEmployee> Employees { get; set; }
        public Manager(string id, string firstName, string lastName, decimal salary, string department,HashSet<RegularEmployee> employees ) : base(id, firstName, lastName, salary, department)
        {
            this.Employees = new HashSet<RegularEmployee>(employees);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine("Subordinates: ");
            foreach (var regularEmployee in Employees)
            {
                result.Append("\t" + regularEmployee.FirstName);
                result.Append(" " + regularEmployee.LastName + "\n");
            }
            return result.ToString();
        }
    }
}
