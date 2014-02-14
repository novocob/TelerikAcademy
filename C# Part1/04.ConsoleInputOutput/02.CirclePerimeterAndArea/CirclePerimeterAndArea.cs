/*  Write a program that reads the radius r of 
 * a circle and prints its perimeter and area.  */


using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius : ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}

