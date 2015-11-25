using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    internal class Tomcat : Cat

    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the {1} says miauu!", this.Name,this.GetType().Name.ToLower());
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
