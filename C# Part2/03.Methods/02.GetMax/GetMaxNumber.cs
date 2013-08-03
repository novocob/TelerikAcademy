/* Write a method GetMax() with two parameters 
 * that returns the bigger of two integers. 
 * Write a program that reads 3 integers from 
 * the console and prints the biggest of them using the method GetMax().*/

using System;
class GetMaxNumber
{
    static void Main()
    {
        Console.WriteLine("Enter three integer numbers!");
        Console.Write("First number: ");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondInteger = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdInteger = int.Parse(Console.ReadLine());

        if (GetMax(firstInteger, secondInteger) >= thirdInteger)
        {
            Console.WriteLine("The bigest number is {0}", GetMax(firstInteger, secondInteger));
        }
        else
        {
            Console.WriteLine("The bigest number is {0}", thirdInteger);
        }
    }

    static int GetMax (int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

