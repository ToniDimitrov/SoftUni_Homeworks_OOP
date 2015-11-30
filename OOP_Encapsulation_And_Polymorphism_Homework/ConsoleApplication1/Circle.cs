using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circle:IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius must be positive");
                } 
                radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return Math.PI*2*Radius;
        }
    }
}
