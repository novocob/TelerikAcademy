using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[10] { 5, 14, 21, 30, 42, 83, 110, 147, 170, 200 };
            //lambda
            int[] result = numbers.Where(x => (x % 3 == 0) && (x % 7 == 0)).ToArray();
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //LINQ
            var resultNumbers =
                from num in numbers
                where (num % 3 == 0) && (num % 7 == 0)
                select num;
            foreach (int num in resultNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
