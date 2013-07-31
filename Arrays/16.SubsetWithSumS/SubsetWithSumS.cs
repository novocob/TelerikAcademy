/*  16.* We are given an array of integers and a number S.
 *  Write a program to find if there exists a subset of 
 *  the elements of the array that has a sum S. */

using System;
class SubsetWithSumS
{
    static void Main()
    {
        //input array and sum
        Console.Write("Enter the number of integers in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("arr{0} : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());

        //method FindSum finds all possible sums of m elements
        //and compares them with sum S
        for (int m = 1; m <= n; m++)
        {
            FindSum(m, arr, sumS, n);
        }
    }

    static void FindSum(int m, int[]arr, int sumS, int n)
    {
        int sum = 0;
        int[] index = new int[m];   //int[] index keeps the combinations of the indexes of the elements of the int[] arr
        for (int i = 0; i < m; i++)
        {
            index[i] = i;
        }

        // in this loop are made all combinations of the indexes of m elements.
        while (true)
        {
            int position = m - 1;
            int topIndex = n - 1;
            sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += arr[index[i]];   // here the sum of the current combination is calculated
            }
            if (sum == sumS)            // here the current combination is printed if sum=sumS
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0}, ",arr[index[i]]);
                }
                Console.WriteLine();
            }
            index[position] += 1;       // here we change the last element of the combination of indexes and
                                        // if the index <= topIndex we calculate the next sum

            // if index > topIndex we have to move to the next position in int[] index
            while (index[position] > topIndex)
            {
                index[position] -= 1;
                position--;
                topIndex--;
                if (position < 0)
                {
                    return;
                }
                if (index[position] <= topIndex)
                {
                    index[position] += 1;
                    if (index[position] <= topIndex)
                    {
                        index[position + 1] = index[position] + 1;
                    }
                }
            }
        }
    }      
}

