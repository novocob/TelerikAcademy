/* 01. Write a program that reads a year from the console 
 *     and checks whether it is a leap. Use DateTime.*/

using System;

class IsYearLeap
{
    static void Main()
    {
        Console.Write("Enter a year : ");
        int year = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(year);
        if (isLeapYear)
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}

