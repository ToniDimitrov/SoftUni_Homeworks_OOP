using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum;

namespace Problem3_Game_Engine
{
    internal class Pill : Bonus
    {
        public Pill(string id) : base(id, 0, 0, 100)
        {
            this.Timeout = 1;
        }
    }
}