using System;

namespace ConsoleApplication1
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * base.Height / 2;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Surface of triangle ({0},{1}) is: {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
