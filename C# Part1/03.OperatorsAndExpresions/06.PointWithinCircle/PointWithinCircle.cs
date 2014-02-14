/*  Write an expression that checks if 
    given point (x,  y) is within a circle K(O, 5). */


using System;
class PointWithinCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        /* Check if the distance between point (x,y) 
        and point (0,0) is bigger than the radius of the circle */
        double distance = Math.Sqrt(x * x + y * y);
        if (distance <= 5)
        {
            Console.WriteLine("The point ({0},{1}) is within the circle K(0,5).", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) is out of the circle K(0,5).", x, y);
        }
    }
}

