/*  Write a program that reads a number N and calculates the sum 
 * of the first N members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …    */

using System;
using System.Numerics;
class FibonacciSequence
{
    static void Main()
    {
        byte firstNumber = 0;
        byte secondNumber = 1;
        BigInteger tempA, tempB, sum;

        tempA = 0;
        tempB = 1;

        Console.Write("Enter integer number N (N>1) : ");
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("1 -> {0}", firstNumber);
        Console.WriteLine("2 -> {0}", secondNumber);

        for (byte i = 3; i <= numberN; i++)
        {
            sum = tempA + tempB;
            Console.WriteLine("{0} -> {1}", i, sum);
            tempA = tempB;
            tempB = sum;
        }  
    }
}

