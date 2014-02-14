/*  In the combinatorial mathematics, the Catalan numbers 
 * are calculated by the following formula:
Cn=(2n)! / (n+1)!n! , for n>=0
Write a program to calculate the Nth Catalan number by given N. */

using System;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number n>=0 : ");
        int n = int.Parse(Console.ReadLine());

        // Cn=(2n)! / (n+1)!n! = (n+2)*(n+3)*..*(2n-1)*2n / n!
        int factorialN = 1;
        int product = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int i = n + 2; i <= 2 * n; i++)
        {
            product *= i;
        }

        int Cn = product / factorialN;
        Console.WriteLine("Cn = {0}", Cn);
    }
}

