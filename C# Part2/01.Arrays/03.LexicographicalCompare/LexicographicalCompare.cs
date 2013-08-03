/* 03. Write a program that compares two char arrays 
 * lexicographically (letter by letter).    */

using System;
class LexicographicalCompare
{
    static void Main()
    {
        Console.WriteLine("First Array.");
        Console.WriteLine("Enter the chars on a single line, without intervals between them:");
        string firstString = Console.ReadLine();
        Console.WriteLine("Second Array.");
        Console.WriteLine("Enter the chars on a single line, without intervals between them:");
        string secondString = Console.ReadLine();

        int maxIndex = Math.Min(firstString.Length, secondString.Length);
        for (int i = 0; i < maxIndex; i++)
        {
            if (firstString[i] < secondString[i])
            {
                Console.WriteLine("First array is lexicographically less than second array.");
                return;
            }
            if (firstString[i] > secondString[i])
            {
                Console.WriteLine("Second array is lexicographically less than first array.");
                return;
            }
        }

        if (firstString.Length < secondString.Length)
        {
            Console.WriteLine("First array is lexicographically less than second array.");
        }
        else if (firstString.Length > secondString.Length)
        {
            Console.WriteLine("Second array is lexicographically less than first array.");
        }
        else
        {
            Console.WriteLine("First array is lexicographically equal to second array.");
        }
    }
}

