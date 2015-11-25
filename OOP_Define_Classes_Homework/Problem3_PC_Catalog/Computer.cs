using System;
using System.Collections.Generic;
using System.Globalization;

namespace Problem3_PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Component> componentsComputer;
        private double price;

        public Computer(string name, List<Component> components)
        {
            Name = name;
            componentsComputer= new List<Component>();
            for (int i = 0; i < components.Count; i++)
            {
                componentsComputer.Add(components[i]);
            }
            Price = price;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw  new ArgumentException("The value must be non-empty","Computer name");
                }
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                double priceComputer = componentsComputer[0].Price;
                for (int i = 1; i < componentsComputer.Count; i++)
                {
                    priceComputer += componentsComputer[i].Price;
                }
                price = priceComputer;
            }
        }

        public void Display()
        {
            Console.WriteLine("Computer name: {0}",Name);
            for (int i = 0; i < componentsComputer.Count; i++)
            {
                Console.WriteLine("Component {0} name: {1}",i,componentsComputer[i].Name);
                Console.WriteLine("Component {0} price: {1}",i,componentsComputer[i].Price);
                if (componentsComputer[i].Details != null)
                {
                    Console.WriteLine("Component {0} details: {1}",i,componentsComputer[i].Details);
                }
            }
            Console.WriteLine("Computer price: {0}",Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
            Console.WriteLine();
        }
    }
}
