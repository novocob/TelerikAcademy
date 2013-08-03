/*  Write a program that gets a number n and after 
 * that gets more n numbers and calculates and prints their sum. */


using System;
class SomeNumbersAndSum
{
    static void Main()
    {
        Console.Write("Enter number n : ");
        double n = double.Parse(Console.ReadLine());
        double sum = n;
        
        while (true)
        {
            Console.Write("Enter next number n or press \"enter\" to calculate sum: ");
            string input = Console.ReadLine();
            if (input == "") break;
            double nNew = double.Parse(input);
            sum = sum + nNew;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}

