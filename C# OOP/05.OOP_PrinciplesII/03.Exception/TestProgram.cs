using System;

namespace _03.Exception
{
    class TestProgram
    {
        static void Main()
        {
            int minNumber = 1;
            int maxNumber = 100;
            DateTime minDate = new DateTime(1980, 1, 1);
            DateTime maxDate = new DateTime(2013, 12, 31);

            try
            {
                int number = EnterNumber(minNumber, maxNumber);
                Console.WriteLine("{0} is valid number.", number);
            }
            catch(InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0} Number must be in range [{1}..{2}].", ex.Message, ex.Min, ex.Max);
            }

            try
            {
                DateTime date = EnterDate(minDate, maxDate);
                Console.WriteLine("{0} is valid date.", date.ToString("d"));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0} Date must be in range [{1}....{2}].", ex.Message, ex.Min, ex.Max);
            }
        }

        static int EnterNumber(int min, int max)
        {
            Console.Write("Enter integer number in range [1..100]: ");
            int num = int.Parse(Console.ReadLine());
            if ((num < 1) || (num > 100))
            {
                throw new InvalidRangeException<int>(min, max);
            }
            else
            {
                return num;
            }
        }

        static DateTime EnterDate(DateTime min, DateTime max)
        {
            Console.Write("Enter a date in range [1.1.1980...31.12.2013]: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if((date < min) || (date > max))
            {
                throw new InvalidRangeException<DateTime>(min, max);
            }
            else
            {
                return date;
            }
        }
    }
}
