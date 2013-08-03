/*  Write a program to print the first 100 members 
 * of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …    */


using System;
using System.Numerics;
class PrintFibonacci
{
    static void Main()
    {
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger nextNum;
        Console.Write(firstNum);
        Console.Write(" ,{0}",secondNum);

        for (int i = 3; i <= 100; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;

            Console.Write(" ,{0}", nextNum);
        }
    }
}

