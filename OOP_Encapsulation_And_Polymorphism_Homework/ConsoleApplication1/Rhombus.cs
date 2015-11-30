using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rhombus:BasicShape
    {
        public Rhombus(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (Width*Height)/2;
        }

        public override double CalculatePerimeter()
        {
            return (Width + Height)*2;
        }
    }
}
