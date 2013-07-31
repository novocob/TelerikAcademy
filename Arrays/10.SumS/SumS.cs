/*  10. Write a program that finds in given array of integers 
 *  a sequence of given sum S (if present). 
 *  Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}    */

using System;
class SumS
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

        Console.Write("Enter number S: ");
        int S = int.Parse(Console.ReadLine());

        int sum = 0;
        bool checkSum = false;
        for (int i = 0; i < n; i++) //Starting position of sequence
        {
            for (int k = 1; k <= n - i; k++) //Length of sequence
            {
                for (int m = i; m < i + k; m++)
                {
                    sum += array[m];
                }
                if (sum == S)
                {
                    checkSum = true;
                    for (int f = i; f < i + k; f++)
                    {
                        Console.Write("{0}, ", array[f]);
                    }
                    Console.WriteLine();
                }
                sum = 0;
            }
        }
        if (checkSum == false)
        {
            Console.WriteLine("There is no sequence of sum {0}.", S);
        }
    }
}

