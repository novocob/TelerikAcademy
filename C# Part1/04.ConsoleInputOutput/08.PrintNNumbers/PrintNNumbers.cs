/* Write a program that reads an integer number n 
 * from the console and prints all the numbers 
 * in the interval [1..n], each on a single line.   */

using System;
class PrintNNumbers
{
    static void Main()
    {
        Console.Write("Enter number n : ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
        else
            for (int i = 1; i >= n; i--)
                Console.WriteLine(i);
    }
}

