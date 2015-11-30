using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class BasicShape:IShape
    {
        private double height;
        private double width;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height must be positive");
                }
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width must be positive");
                }
                this.width = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
