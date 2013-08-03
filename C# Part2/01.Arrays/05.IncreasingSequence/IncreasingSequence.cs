/* 05. Write a program that finds the maximal increasing sequence 
 * in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;
class IncreasingSequence
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
        int bestIndex = 0;      // The  position of the last element in the best sequence
        int maxLength = 0;    // Length of the best sequence
        int count = 1;          // Length of the current sequence
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1]-1)
            {
                count++;
            }
            else
            {
                if (count >= maxLength)
                {
                    maxLength = count;
                    bestIndex = i;
                }
                count = 1;
            }
        }
        if (count >= maxLength)
        {
            maxLength = count;
            bestIndex = n - 1;
        }
        Console.Write("The maximal sequence is : ");
        for (int i = bestIndex - maxLength + 1; i <= bestIndex; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();
    }
}

