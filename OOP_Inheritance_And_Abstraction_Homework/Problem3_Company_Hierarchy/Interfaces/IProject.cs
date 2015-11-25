using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy.Interfaces
{
    internal interface IProject
    {
        string projectName { get; set; }
        DateTime projectStartDate { get; set; }
        string details { get; set; }
        string state { get; set; }
    }
}
