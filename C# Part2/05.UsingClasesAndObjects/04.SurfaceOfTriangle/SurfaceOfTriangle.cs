/* 04. Write methods that calculate the surface of a triangle by given:
       - Side and an altitude to it; 
 *     - Three sides; 
 *     - Two sides and an angle between them. 
 *     Use System.Math. */

using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(" Choose how to determine the area of triangle:  ");
            Console.WriteLine("************************************************");
            Console.WriteLine("*    1. Side and an altitude to it.            *");
            Console.WriteLine("*    2. Three sides.                           *");
            Console.WriteLine("*    3. Two sides and an angle between them.   *");
            Console.WriteLine("*    4. Exit the program                       *");
            Console.WriteLine("************************************************");
            Console.Write    (" Your choice : ");

            string userChoice = Console.ReadLine();
            Console.WriteLine();
            switch (userChoice)
            {
                case "1": AreaBySideAndAltitude(); break;
                case "2": AreaByThreeSides(); break;
                case "3": AreaByTwoSidesAndAngle(); break;
                case "4": return;
                default : Console.WriteLine("Wrong input!");
                          Console.WriteLine(); break;
            }
        }
    }

    static void AreaBySideAndAltitude()
    {
        Console.Write("Enter side : ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude : ");
        double altitude = double.Parse(Console.ReadLine());

        double area = side * altitude / 2;
        Console.WriteLine("Area is : {0}", area);
        Console.WriteLine();
    }

    static void AreaByThreeSides()
    {
        Console.Write("Enter first side : ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter second side : ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter third side : ");
        double sideC = double.Parse(Console.ReadLine());

        double p = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
        Console.WriteLine("Area is : {0}", area);
        Console.WriteLine();
    }

    static void AreaByTwoSidesAndAngle()
    {
        Console.Write("Enter first side : ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter second side : ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter angle in degrees : ");
        double angle = double.Parse(Console.ReadLine());

        double area = 0.5 * sideA * sideB * Math.Sin(angle * Math.PI / 180);
        Console.WriteLine("Area is : {0}", area);
        Console.WriteLine();
    }
}

