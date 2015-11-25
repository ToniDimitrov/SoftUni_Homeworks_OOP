using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    class Dog:Animal
    {
        public Dog(string name,int age , string gender):base(name,age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the {1} says bau!", this.Name,this.GetType().Name.ToLower());
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
