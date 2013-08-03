/*Write a program to calculate n! for each n in the range [1..100]. */

using System;
using System.Numerics;
class Factorial100
{
    static void Main()
    {
        BigInteger[] factorials = CalculateFactorials();
        
        Console.WriteLine("Enter a number [1..100] to see its factorial : ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}! = {1}", index, factorials[index]);
    }

    //this method calculates factorials from 1 to 100 and keeps them in array
    static BigInteger[] CalculateFactorials()
    {
        BigInteger[] factorials = new BigInteger[101];
        factorials[0] = 1;
        for (int i = 1; i <= 100; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }
        return factorials;
    }
}

