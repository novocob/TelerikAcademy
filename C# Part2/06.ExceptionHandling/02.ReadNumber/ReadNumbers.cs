/* 02.Write a method ReadNumber(int start, int end) 
 *    that enters an integer number in given range [start…end]. 
 *    If an invalid number or non-number text is entered, 
 *    the method should throw an exception. Using this method 
 *    write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100  */

using System;

class ReadNumbers
{
    static void Main()
    {
        int[] numbers = new int[10];
        int startRange = 1;
        int endRange = 100;
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                try
                {
                    numbers[i] = ReadNumber(startRange, endRange);
                    startRange = numbers[i];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }

        Console.WriteLine("You entered these numbers:");
        foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter an integer number in range {0} < NUMBER < {1} : ", start, end);
        int userNumber = int.Parse(Console.ReadLine());
        if ((userNumber <= start) || (userNumber >= end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return userNumber;
    }
}

