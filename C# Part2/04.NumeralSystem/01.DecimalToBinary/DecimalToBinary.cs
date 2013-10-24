/* 01. Write a program to convert decimal 
 *     numbers to their binary representation. */

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter integer number : ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<int> binaryDigits = new List<int>();

        int currentNumber = decimalNumber;
        while (currentNumber > 0)
        {
            binaryDigits.Add(currentNumber % 2);
            currentNumber /= 2;
        }
        binaryDigits.Reverse();
        Console.Write("Binary representation is : ");
        foreach (var i in binaryDigits)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}