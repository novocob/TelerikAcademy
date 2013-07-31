/* 04. Write a program that finds the maximal 
 * sequence of equal elements in an array.*/

using System;
class MaximalSequence    
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
        for (int i = 0; i < n-1; i++)
        {
            if (array[i] == array[i + 1])
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
            bestIndex = n-1;
        }
        Console.Write("The maximal sequence is : ");
        for (int i = bestIndex; i > bestIndex - maxLength; i--)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();
    }
}

