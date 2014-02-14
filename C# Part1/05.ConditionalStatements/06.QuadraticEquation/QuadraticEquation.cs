/*  Write a program that enters the coefficients 
 *  a, b and c of a quadratic equation
    a*x*x + b*x + c = 0 and calculates and prints its real roots. 
 * Note that quadratic equations may have 0, 1 or 2 real roots. */

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of a*x*x + b*x + c = 0");
        double a;
        double b;
        double c;

        while (true)
        {
            Console.Write("a = ");
            bool result = double.TryParse(Console.ReadLine(), out a);
            if (a == 0)
            {
                Console.WriteLine("In a quadratic equation coefficient \"a\" must be a non zero real number!");
            }
            else
            {
                break;
            }
        }
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        double x1;
        double x2;
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (discriminant == 0)
        {
            x1 = -b / 2 * a;
            Console.WriteLine("There is one real root x = {0}", x1);
        }
        else
        {
            x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("There are two real roots:");
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
    }
}

