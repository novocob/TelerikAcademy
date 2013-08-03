/* Write a method that adds two polynomials. 
 * Represent them as arrays of their coefficients.*/

using System;
class AddPolynomials
{
    static void Main()
    {
        decimal[] firstPolynom = { 0, 3, -6, 3, 7};
        decimal[] secondPolynom = { -2, 5, 2};

        Console.WriteLine("First polynom:");
        PrintPolynom(firstPolynom);
        Console.WriteLine();
        Console.WriteLine("Second polynom:");
        PrintPolynom(secondPolynom);
        Console.WriteLine();

        decimal[] resultPolynom = AddPolynoms(firstPolynom, secondPolynom);
        Console.WriteLine("Result polynom:");
        PrintPolynom(resultPolynom);
        
    }

    static decimal[] AddPolynoms(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        int longerLength = Math.Max(firstPolynom.Length, secondPolynom.Length);
        int shorterLength = Math.Min(firstPolynom.Length, secondPolynom.Length);
        decimal[] resultPolynom = new decimal[longerLength];
        for (int i = 0; i < shorterLength; i++)
        {
            resultPolynom[i] = firstPolynom[i] + secondPolynom[i];
        }
        for (int i = shorterLength; i < longerLength; i++)
        {
            if (firstPolynom.Length > secondPolynom.Length)
            {
                resultPolynom[i] = firstPolynom[i];
            }
            if (firstPolynom.Length < secondPolynom.Length)
            {
                resultPolynom[i] = secondPolynom[i];
            }
        }
        return resultPolynom;
    }

    static void PrintPolynom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i > 0; i-- )
        {
            if (polynom[i] == 0)
            {
                continue;
            }
            else
            {
                if (polynom[i - 1] > 0)
                {
                    Console.Write("{0}x^{1} + ", polynom[i], i);
                }
                if (polynom[i - 1] < 0)
                {
                    Console.Write("{0}x^{1} ", polynom[i], i);
                }
                if (polynom[i - 1] == 0)
                {
                    Console.Write("{0}x^{1} ", polynom[i], i);
                }
            }
        }
        if (polynom[0] != 0)
        {
            Console.WriteLine("{0}", polynom[0]);
        }
    }
}

