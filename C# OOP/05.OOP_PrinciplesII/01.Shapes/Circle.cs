using System;

namespace ConsoleApplication1
{
    public class Circle : Shape
    {
        public Circle(double height)
        {
            this.Height = height;
            this.Width = height;
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Height * Math.PI / 4;  // S = (diameter * diameter * Pi) / 4 
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Surface of circle ({0}) is: {1}", this.Height, this.CalculateSurface());
        }
    }
}
