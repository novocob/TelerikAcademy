/* Write methods to calculate minimum, maximum, average,
 * sum and product of given set of integer numbers. 
 * Use variable number of arguments.    */

using System;
class MinMaxSumProduct
{
    static void Main()
    {
        Console.WriteLine("Minimal number of set is: {0}",      FindMinNumber(5, -10, 8, -2));
        Console.WriteLine("Maximal number of set is: {0}",      FindMaxNumber(5, -10, 8, -2));
        Console.WriteLine("Sum of numbers in set is: {0}",      FindSum      (5, -10, 8, -2));
        Console.WriteLine("Average of numbers in set is: {0}",  FindAverage  (5, -10, 8, -2));
        Console.WriteLine("Product of numbers in set is: {0}",  FindProduct  (5, -10, 8, -2));
    }

    static int FindMinNumber(params int[] numbers)
    {
        int minNumber = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number <= minNumber)
            {
                minNumber = number;
            }
        }
        return minNumber;
    }

    static int FindMaxNumber(params int[] numbers)
    {
        int maxNumber = int.MinValue;
        foreach (int number in numbers)
        {
            if (number >= maxNumber)
            {
                maxNumber = number;
            }
        }
        return maxNumber;
    }

    static int FindSum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static double FindAverage(params int[] numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        double average = sum / numbers.Length;
        return average;
    }

    static int FindProduct(params int[] numbers)
    {
        int product = 1;
        foreach (int number in numbers)
        {
            product *= number;
        }
        return product;
    }
}

