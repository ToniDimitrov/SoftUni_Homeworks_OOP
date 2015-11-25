using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy
{
    interface IEmployee:IPerson
    {
        string Department { get; set; }
        decimal Salary { get; set; }
    }
}
