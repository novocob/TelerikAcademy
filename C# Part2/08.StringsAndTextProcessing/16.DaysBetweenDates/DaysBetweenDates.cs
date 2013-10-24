/* 16. Write a program that reads two dates in the format: 
 * day.month.year and calculates the number of days between them.
 * Example:
    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days  */

using System;

class DaysBetweenDates
{
    static void Main()
    {
        Console.Write("Enter first date (day.month.year): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(firstDate.ToString("d"));
        Console.Write("Enter second date (day.month.year): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan diference = secondDate.Subtract(firstDate);
        Console.WriteLine("Distance: " + Math.Abs(diference.Days) + " days");
    }
}
