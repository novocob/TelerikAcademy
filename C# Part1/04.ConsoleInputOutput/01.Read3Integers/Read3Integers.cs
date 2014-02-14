/*  Write a program that reads 3 integer numbers 
 * from the console and prints their sum.   */


using System;
class Read3Integers
{
    static void Main()
    {
        Console.Write("Enter the first number : ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number : ");
        int numberThree = int.Parse(Console.ReadLine());

        int sum = numberOne + numberTwo + numberThree;
        Console.WriteLine("{0} + {1} + {2} = {3}", numberOne, numberTwo, numberThree, sum);
    }
}

