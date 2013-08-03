/*  09. Write a program that finds the most frequent number in an array. 
 *  Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)   */

using System;
class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter number of elements : ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine();
        Console.WriteLine("Enter the elements of array.");
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int count = 1;
        int bestIndex = 0;
        int bestCount = 1;
        for (int i = 0; i < n-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
            }
            else
            {
                if (count >= bestCount)
                {
                    bestIndex = i;
                    bestCount = count;
                }
                count = 1;
            }
        }
        Console.WriteLine("The most frequent number is: {0}", array[bestIndex]);
        Console.WriteLine("Number of times: {0}", bestCount);
    }
}

