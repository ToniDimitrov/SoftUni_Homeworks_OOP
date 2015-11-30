using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum;

namespace Problem3_Game_Engine
{
    internal class Injection : Bonus
    {
        public Injection(string id) : base(id, 200, 0, 0)
        {
            this.Timeout = 3;
        }
    }
}