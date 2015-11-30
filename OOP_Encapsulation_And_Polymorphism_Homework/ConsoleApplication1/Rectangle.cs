using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle: BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return Width*Height;
        }

        public override double CalculatePerimeter()
        {
            return (Width + Height)*2;
        }
    }
}
