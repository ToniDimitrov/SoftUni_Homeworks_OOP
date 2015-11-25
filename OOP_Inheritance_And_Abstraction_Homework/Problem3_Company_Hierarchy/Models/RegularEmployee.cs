using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3_Company_Hierarchy.Interfaces;

namespace Problem3_Company_Hierarchy
{
    abstract class RegularEmployee:Employee,IRegularEmployee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, string department) : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
