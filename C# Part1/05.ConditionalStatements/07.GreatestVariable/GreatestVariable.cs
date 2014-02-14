/*  Write a program that finds the greatest of given 5 variables. */

using System;
class GreatestVariable
{
    static void Main()
    {
        double[] variable = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("var{0} = ", i);
            variable[i] = double.Parse(Console.ReadLine());
        }

        // Finding which value is the greatest //
        double maxVariable = variable[1];
        for (int i = 0; i < 5; i++)
        {
            if (variable[i] > maxVariable)
            {
                maxVariable = variable[i];
            }
        }

        // Finding which variables have this value //
        Console.WriteLine("The greatest of the 5 variables:");
        for (int i = 0; i < 5; i++)
        {
            if (variable[i] == maxVariable)
            {
                Console.WriteLine("var{0}", i);
            }
        }
    }
}

