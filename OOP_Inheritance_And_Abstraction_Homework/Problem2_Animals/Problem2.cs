using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    internal class Problem2
    {
        private static void Main(string[] args)
        {
            Animal[] animals = new Animal[7];
            try
            {
                animals[0] = new Cat("Lara",4,"Female");
                animals[1] = new Cat("Sara", 6, "Female");
                animals[2] = new Tomcat("Gosho", 1);
                animals[3] = new Kitten("Mia", 2);
                animals[4] = new Frog("Kreko", 4, "Male");
                animals[5] = new Dog("Sharo", 9, "Male");
                animals[6] = new Dog("Jonkata", 12, "Male");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            double averageAge = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ProduceSound();

                averageAge += animals[i].Age;
            }

            Animal newDog = animals[6];
            Console.WriteLine(newDog);
            Console.WriteLine("Average age of the animals: {0:F} years", averageAge /= animals.Length);
           
        }
    }
}
