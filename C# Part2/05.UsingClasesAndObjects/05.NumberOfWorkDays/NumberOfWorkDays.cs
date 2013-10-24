/* 05. Write a method that calculates the number of 
 *     workdays between today and given date, 
 *     passed as parameter. Consider that workdays are all days 
 *     from Monday to Friday except a fixed list of 
 *     public holidays specified preliminary as array. */

using System;
using System.Collections.Generic;

class NumberOfWorkDays
{
    static void Main()
    {
        DateTime todayDate = DateTime.Today;
        DateTime futureDate = EnterValidFutureDate(todayDate);
        int workDays = CalculateWorkDays(todayDate, futureDate);
        Console.WriteLine("Workdays between today - {0} and {1} are {2}.", todayDate.ToString("d"), futureDate.ToString("d"), workDays);  
    }

    static DateTime EnterValidFutureDate(DateTime todayDate)
    //this method checks if the date entered by the user is correct
    //and if it is in the future
    {
        while (true)
        {
            Console.Write("Enter a future date (day.month.year) : ");
            string futureDay = Console.ReadLine();
            DateTime futureDate;
            bool successParse = DateTime.TryParse(futureDay, out futureDate);
            if (successParse)
            {
                int compare = todayDate.CompareTo(futureDate);
                if (compare < 0)
                {
                    return futureDate;
                }
                else
                {
                    Console.WriteLine("The date must be in future!");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    } 

    static int CalculateWorkDays(DateTime todayDate, DateTime futureDate)
    {
        int allDays = (int)(futureDate - todayDate).TotalDays; //these are all days between today and the future date.
        int workDays = allDays;
        List<DateTime> holidays = FindHolidays(todayDate, futureDate); //here is generated List of holidays
        for (int count = 1; count <= allDays; count++)
        {
            DateTime nextDate = todayDate.AddDays(count); //every date between now and the future date is checked if it is
                                                          //saturday or sunday or holiday
            if ((nextDate.DayOfWeek == DayOfWeek.Saturday) || (nextDate.DayOfWeek == DayOfWeek.Sunday) || (holidays.Contains(nextDate)))
            {
                workDays--;
            }
        }
        return workDays;
    }

    static List<DateTime> FindHolidays(DateTime todayDate, DateTime futureDate)
    //in this method is generated a list of all holidays between now and the year of the future date
    //in the list are included only holidays that are always on the same date
    {
        List<DateTime> listOfHolidays = new List<DateTime>();
        int year = futureDate.Year;
        for (int i = todayDate.Year; i <= futureDate.Year; i++)
        {
            listOfHolidays.Add(new DateTime(i, 1, 1));
            listOfHolidays.Add(new DateTime(i, 3, 3));
            listOfHolidays.Add(new DateTime(i, 5, 1));
            listOfHolidays.Add(new DateTime(i, 5, 6));
            listOfHolidays.Add(new DateTime(i, 5, 24));
            listOfHolidays.Add(new DateTime(i, 9, 6));
            listOfHolidays.Add(new DateTime(i, 9, 22));
            listOfHolidays.Add(new DateTime(i, 12, 24));
            listOfHolidays.Add(new DateTime(i, 12, 25));
            listOfHolidays.Add(new DateTime(i, 12, 26));
        }
        return listOfHolidays;
    }
}

