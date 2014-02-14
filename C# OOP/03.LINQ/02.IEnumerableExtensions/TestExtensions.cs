using System;

namespace _02.IEnumerableExtensions
{
    class TestExtensions
    {
        static void Main()
        {
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            int sum = numbers.Sum();
            int product = numbers.Product();
            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(minNumber);
            Console.WriteLine(maxNumber);
            Console.WriteLine(average);

        }
    }
}
