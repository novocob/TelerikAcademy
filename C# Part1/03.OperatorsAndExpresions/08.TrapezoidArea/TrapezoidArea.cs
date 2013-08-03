/*  Write an expression that calculates trapezoid's 
    area by given sides a and b and height h.    */


using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Input a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input h : ");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = (a + b) * h / 2;
        Console.WriteLine("Trapezoid's area is : {0}", trapezoidArea);

    }
}

