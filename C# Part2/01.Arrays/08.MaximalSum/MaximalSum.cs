/*  08. Write a program that finds the sequence
 *  of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} */

using System;
class MaximalSum
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

        int sum = 0;
        int bestSum = 0;
        int bestIndex = 0;
        int bestLength = 0;
        for (int k = 0; k < n; k++) //check all sums with k elements
        {
            for (int i = 0; i < n - k; i++) //i is the starting position of the sequence
            {
                for (int m = i; m <= i + k; m++)  //calculate sum of k elements strarting form position i
                {
                    sum += array[m];
                }
                if (sum >= bestSum)
                {
                    bestSum = sum;
                    bestIndex = i;
                    bestLength = k;
                }
                sum = 0;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sequence of maximal sum is:");
        for (int i = bestIndex; i <= bestIndex + bestLength; i++)
        {
            Console.Write("{0}, ",array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}

