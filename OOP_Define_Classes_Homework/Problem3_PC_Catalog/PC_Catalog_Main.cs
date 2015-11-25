using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_PC_Catalog
{
    class PC_Catalog_Main
    {
        static void Main(string[] args)
        {
            List<Component> components =  new List<Component>();

            components.Add(new Component("CPU",250.39,"Intel i5 2.50 Ghz"));
            components.Add(new Component("RAM",80,"6 GB"));
            components.Add(new Component("HDD",120));

            List<Component> components2 =  new List<Component>();

            components2.Add(new Component("CPU",429.99,"Intel i7 2.50 - 3.20 Ghz"));
            components2.Add(new Component("RAM",160,"12 GB"));
            components2.Add(new Component("HDD",240));

            List<Component> components3 = new List<Component>();

            components3.Add(new Component("CPU", 55.01, "Intel Core Duo 1.3 Ghz"));
            components3.Add(new Component("RAM", 49.99, "2 GB"));
            components3.Add(new Component("HDD", 80,"220 GB"));

            List<Computer> computers = new List<Computer>();
            computers.Add(new Computer("Computer 1",components));
            computers.Add(new Computer("Computer 2",components2));
            computers.Add(new Computer("Computer 3",components3));

            List<Computer> sortedComputers = computers.OrderBy(price => price.Price).ToList();

            sortedComputers.ForEach(computer => computer.Display());


        }
    }
}
