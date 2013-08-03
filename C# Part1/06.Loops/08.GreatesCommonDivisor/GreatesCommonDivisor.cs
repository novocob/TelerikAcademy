/*  Write a program that calculates the greatest common divisor (GCD) 
 * of given two numbers. Use the Euclidean algorithm .  */

using System;
class GreatesCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first integer number : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer number : ");
        int b = int.Parse(Console.ReadLine());

        int biggerNum = Math.Max(Math.Abs(a), Math.Abs(b));
        int smallerNum = Math.Min(Math.Abs(a), Math.Abs(b));

        if (smallerNum == 0)
        {
            Console.WriteLine("GCD of {0} and {1} is {2}.", a, b, biggerNum);
        }
        else
        {
            int reminder = biggerNum % smallerNum;
            if (reminder == 0)
            {
                Console.WriteLine("GCD of {0} and {1} is {2}.", a, b, smallerNum);
            }
            else
            {
                while (reminder > 0)
                {
                    biggerNum = smallerNum;
                    smallerNum = reminder;
                    reminder = biggerNum % smallerNum;
                }
                Console.WriteLine("GCD of {0} and {1} is {2}.", a, b, smallerNum);
            }
        }
    }
}

