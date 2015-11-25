using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    class Kitten:Cat
    {
        public Kitten(string name, int age) : base(name, age,"Female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the {1} says miauu!", this.Name, this.GetType().Name.ToLower());
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
