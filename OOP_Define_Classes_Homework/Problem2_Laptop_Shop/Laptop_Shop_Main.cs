using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Laptop_Shop
{
    class Laptop_Shop_Main
    {
        static void Main(string[] args)
        {
            Laptop fullDescriptionLaptop = new Laptop("Lenovo Yoga 2 Pro", "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400",
                "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "2259.00 lv.",
                "Li-Ion, 4-cells, 2550 mAh", "4.5 hours");
            Laptop minimumDescription = new Laptop("HP ProBook 4530","1200 lv.");
            Laptop graphicsDescriptionLaptop = new Laptop("Sony VAIO", "1653,23 BGN","Sony","AMD Radeon HD 6700m","17,2\" HD Ready");
            Laptop otherDescriptionLaptop = new Laptop("HP Pavillion","HP","900 EUR","8 Gb","2.60 - 3.20 GHz Intel i7","1TB HDD");
            Laptop batteryDescriptionLaptop = new Laptop("Dell Inspiron","1222 usd","66.6 hours","66 cell Li-Ion");

            Console.WriteLine(fullDescriptionLaptop);
            Console.WriteLine(minimumDescription);
            Console.WriteLine(graphicsDescriptionLaptop);
            Console.WriteLine(otherDescriptionLaptop);
            Console.WriteLine(batteryDescriptionLaptop);
        }
    }
}
