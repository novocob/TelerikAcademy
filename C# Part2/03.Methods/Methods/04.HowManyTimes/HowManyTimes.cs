/* Write a method that counts how many times given number
 * appears in given array. Write a test program
 * to check if the method is working correctly. */

using System;
class HowManyTimes
{
    static void Main()
    {
        int[] numbers = new int[] { 2, 2, 4, 5, 5, 5, 7, 10 };
        Console.WriteLine("These are the elements in the array:");
        foreach (int num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.Write("Enter a number from the array: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        int appearences = CountAppearances(numbers, searchedNumber);
        Console.WriteLine("Number {0} appears {1} times in the array.",searchedNumber, appearences );
    }

    static int CountAppearances(int[]arr, int searchedNumber)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num == searchedNumber)
            {
                count++;
            }
        }
        return count;
    }
}

