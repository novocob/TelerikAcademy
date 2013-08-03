/*  Write a program that calculates N!*K! / (K-N)! 
 * for given N and K (1<N<K).   */

using System;
class FactorialNandK
{
    static void Main()
    {
        int kFactorial = 1;
        int nFactorial = 1;
        int kMinusNFactorial = 1;

        Console.Write("Enter integer number K (K>2) : ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number N (1<N<K): ");
        int n = int.Parse(Console.ReadLine());
        int kMinusN = k - n;

        do
        {
            kFactorial *= k;
            k--;
        } while (k > 0);
        do
        {
            nFactorial *= n;
            n--;
        } while (n > 0);
        do
        {
            kMinusNFactorial *= kMinusN;
            kMinusN--;
        } while (kMinusN > 0);

        int result = nFactorial * kFactorial / kMinusNFactorial;
        Console.WriteLine("N! * K! / (K-N)! = {0}", result);
    }
}

