﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy.Interfaces
{
    interface ICustomer:IPerson
    {
        decimal TotalSpent { get; set; }
    }
}
