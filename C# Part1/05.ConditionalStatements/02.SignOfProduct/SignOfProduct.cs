/*  Write a program that shows the sign (+ or -) 
 * of the product of three real numbers without 
 * calculating it. Use a sequence of if statements. */

using System;
class SignOfProduct
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        double n3 = double.Parse(Console.ReadLine());

        if ((n1 == 0) || (n2 == 0) || (n3 == 0))
        {
            Console.WriteLine("The product is zero.");
        }
        else if (n1 > 0)
        {
            if (((n2 > 0) && (n3 > 0)) || ((n2 < 0) && (n3 < 0)))
            {
                Console.WriteLine("The sign of product is +.");
            }
            else
            {
                Console.WriteLine("The sign of product is -.");
            }
        }
        else if (n1 < 0)
        {
            if (((n2 > 0) && (n3 > 0)) || ((n2 < 0) && (n3 < 0)))
            {
                Console.WriteLine("The sign of product is -.");
            }
            else
            {
                Console.WriteLine("The sign of product is +.");
            }
        }
    }
}

