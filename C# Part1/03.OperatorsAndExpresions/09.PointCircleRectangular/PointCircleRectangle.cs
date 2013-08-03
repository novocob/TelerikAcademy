/*  Write an expression that checks for given point (x, y) 
    if it is within the circle K( (1,1), 3) and out of 
    the rectangle R(top=1, left=-1, width=6, height=2). */


using System;
class PointCircleRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Input x : ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input y : ");
        double y = double.Parse(Console.ReadLine());

        // Check if point is within the circle
        double deltaX = Math.Abs(x - 1);
        double deltaY = Math.Abs(y - 1);
        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        bool isWithinCircle = (distance <= 3);

        // Check if point is out of rectangle
        bool isOutOfRectangle = ((x < -1) || (x > 5) || (y < -1) || (y > 1));

        // Final check
        bool finalCheck = (isWithinCircle && isOutOfRectangle);

        Console.WriteLine("The point is within circle and out of rectangle : {0}", finalCheck);
    }
}
