/*  Write a program that calculates N!/K! for given N and K (1<K<N). */

using System;
class NdevidedByK
{
    static void Main()
    {
        int nFactorial=1;
        int kFactorial=1;

        Console.Write("Enter integer number N (N>2) : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number K (1<K<N): ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }
        int result = nFactorial / kFactorial;
        Console.WriteLine("N! / K! = {0}", result);
    }
}

