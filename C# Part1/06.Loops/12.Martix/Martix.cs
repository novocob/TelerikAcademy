/*  Write a program that reads from the console 
 * a positive integer number N (N < 20) and outputs 
 * a matrix like the following: */

using System;
class Martix
{
    static void Main()
    {
        Console.Write("Enter positive integer number N < 20 :");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            for (int j = i; j < (number+i); j++)
            {
                Console.Write("{0,3}",j);
            }
            Console.WriteLine();
        }
    }
}

