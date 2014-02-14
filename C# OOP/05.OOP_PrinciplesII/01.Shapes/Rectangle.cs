using System;

namespace ConsoleApplication1
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double  CalculateSurface()
        {
 	        double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("Surface of rectangle ({0},{1}) is: {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
