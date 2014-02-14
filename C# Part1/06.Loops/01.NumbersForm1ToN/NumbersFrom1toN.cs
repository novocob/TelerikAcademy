/*  Write a program that prints all the numbers from 1 to N. */

using System;
class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

