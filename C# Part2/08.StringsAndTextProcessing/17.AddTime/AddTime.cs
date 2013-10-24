/* 17.Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and prints the date and time after 
 * 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.   */

using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _17.AddTime
{
    class AddTime
    {
        static void Main()
        {
            Console.WriteLine("Enter a date and time (day.month.year hour:minute:second) : ");
            DateTime inputDateTime = DateTime.Parse(Console.ReadLine());
            DateTime newDateTime = inputDateTime.AddHours(6.5);
            Console.WriteLine("{0} {1}", newDateTime.ToString("dddd", new CultureInfo("bg-BG")), newDateTime);
        }
    }
}
