/*  Write a program that finds the biggest 
 * of three integers using nested if statements.    */

using System;
class TheBiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer : ");
        int n3 = int.Parse(Console.ReadLine());

        if (n1 >= n2)
        {
            if (n1 >= n3)
            {
                Console.WriteLine("The biggest integer is : {0}", n1);
            }
            else
            {
                Console.WriteLine("The biggest integer is : {0}", n3);
            }
        }
        else
            if (n2 >= n3)
            {
                Console.WriteLine("The biggest integer is : {0}", n2);
            }
            else
            {
                Console.WriteLine("The biggest integer is : {0}", n3);
            }
    }
}

