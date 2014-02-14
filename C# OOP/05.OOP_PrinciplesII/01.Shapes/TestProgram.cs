using System;

namespace ConsoleApplication1
{
    class TestProgram
    {
        static void Main()
        {
            Shape[] shapes = new Shape[3] 
                { new Rectangle(4, 3), new Triangle(2, 2), new Circle(2) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine();
            }
        }
    }
}
