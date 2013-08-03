/* Extend the program from task 11 to support
 * also subtraction and multiplication of polynomials.*/

using System;
class SubstractMultiplyPolynom
{
    static void Main()
    {
        decimal[] firstPolynom = { 3, -8, 6};
        decimal[] secondPolynom = { 2, 4};

        Console.WriteLine("First polynom:");
        PrintPolynom(firstPolynom);
        Console.WriteLine();
        Console.WriteLine("Second polynom:");
        PrintPolynom(secondPolynom);
        Console.WriteLine();

        decimal[] resultSubstraction = SubstractPolynoms(firstPolynom, secondPolynom);
        Console.WriteLine("Result from substraction (First polynom - Second polynom) :");
        PrintPolynom(resultSubstraction);
        Console.WriteLine();

        decimal[] resultMultiplication = MultiplyPolynoms(firstPolynom, secondPolynom);
        Console.WriteLine("Result from multiplication :");
        PrintPolynom(resultMultiplication);
        Console.WriteLine();
    }

    static decimal[] SubstractPolynoms(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        int longerLength = Math.Max(firstPolynom.Length, secondPolynom.Length);
        int shorterLength = Math.Min(firstPolynom.Length, secondPolynom.Length);
        decimal[] resultPolynom = new decimal[longerLength];
        for (int i = 0; i < shorterLength; i++)
        {
            resultPolynom[i] = firstPolynom[i] - secondPolynom[i];
        }
        for (int i = shorterLength; i < longerLength; i++)
        {
            if (firstPolynom.Length > secondPolynom.Length)
            {
                resultPolynom[i] = firstPolynom[i];
            }
            if (firstPolynom.Length < secondPolynom.Length)
            {
                resultPolynom[i] = - secondPolynom[i];
            }
        }
        return resultPolynom;
    }

    static decimal[] MultiplyPolynoms(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        int longerLength = Math.Max(firstPolynom.Length, secondPolynom.Length);
        int shorterLength = Math.Min(firstPolynom.Length, secondPolynom.Length);
        decimal[] resultPolynom = new decimal[longerLength + shorterLength];
        for (int i = firstPolynom.Length - 1; i >= 0; i--)
        {
            for (int j = secondPolynom.Length - 1; j >= 0; j--)
            {
                resultPolynom[i + j] += firstPolynom[i] * secondPolynom[j];
            }
        }
        return resultPolynom;
    }

    static void PrintPolynom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i > 1; i--)
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
        if (polynom[1] != 0)
        {
            if (polynom[0] > 0)
            {
                Console.Write("{0}x + ", polynom[1]);
            }
            if (polynom[0] < 0)
            {
                Console.Write("{0}x - ", polynom[1]);
            }
            if (polynom[0] == 0)
            {
                Console.Write("{0}x ", polynom[1]);
            }
        }
        if (polynom[0] != 0)
        {
            Console.WriteLine("{0}", polynom[0]);
        }
    }
}

