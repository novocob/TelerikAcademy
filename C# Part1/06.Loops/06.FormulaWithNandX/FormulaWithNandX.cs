/*  Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN  */

using System;
class FormulaWithNandX
{
    static void Main()
    {
        int nFactorial = 1;
        double xToPowerN = 1;
        double sumS = 1;

        Console.Write("Enter integer number N (N>0) : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number X : ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nFactorial *=i;
            xToPowerN = Math.Pow(x, i);
            sumS += (nFactorial / xToPowerN);
        }
        Console.WriteLine("The sum is : {0}", sumS);
    }
}

