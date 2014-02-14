/*  Write a program that reads from the console a sequence of N 
 * integer numbers and returns the minimal and maximal of them. */

using System;
class MinAndMaxNumber
{
    static void Main()
    {
        int minValue;
        int maxValue;
        int newValue;

        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers, each on separate line.", number);

        // Enter the first number of the sequence
        Console.Write("Enter number 1 : ");
        newValue = int.Parse(Console.ReadLine());
        minValue = maxValue = newValue;

        // Enter all other numbers of the sequence and compare them at the same time
        for (int i = 2; i <= number; i++)
        {
            Console.Write("Enter number {0} : ", i);
            newValue = int.Parse(Console.ReadLine());
            if (newValue >= maxValue)
            {
                maxValue = newValue;
            }
            if (newValue <= minValue)
            {
                minValue = newValue;
            }
        }
        Console.WriteLine("Minimal value is : {0}", minValue);
        Console.WriteLine("Maximal value is : {0}", maxValue);
    }
}

