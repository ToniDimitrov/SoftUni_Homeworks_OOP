using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    internal class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the {1} says ribbit!", this.Name, this.GetType().Name.ToLower());
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}