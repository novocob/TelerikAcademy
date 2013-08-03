/* Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such that 
 * the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.   */


using System;
class BetweenNumbers
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        uint firstNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        uint secondNumber = uint.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            uint tempNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = tempNumber;
        }

        uint p = 0;
        for (uint i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0) p++;
        }
        Console.WriteLine("p({0},{1}) = {2}", firstNumber, secondNumber, p);
    }
}

