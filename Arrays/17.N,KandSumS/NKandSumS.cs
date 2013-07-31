/* 17.* Write a program that reads three integer numbers 
 * N, K and S and an array of N elements from the console. 
 * Find in the array a subset of K elements that have 
 * sum S or indicate about its absence. */
 
using System;
class NKandSumS
{
    static void Main()
    {
        //input N, K, sum S, elements of array
        Console.Write("Enter the number N (number of integers in the array): ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("arr[{0}] : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the number K (number of elements in subset): ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int sum = 0;
        bool noSubset = true;
        int[] index = new int[k];   //int[] index keeps the combinations of the indexes of K elements of the int[] arr
        for (int i = 0; i < k; i++)
        {
            index[i] = i;
        }

        // in this loop are made all combinations of the indexes of K elements.
        while (true)
        {
            int position = k - 1;
            int topIndex = n - 1;
            sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += arr[index[i]];   // here the sum of the current combination is calculated
            }
            if (sum == sumS)            // here the current combination is printed if sum=sumS
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0}, ", arr[index[i]]);
                }
                noSubset = false;
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
                    if (noSubset == true)
                    {
                        Console.WriteLine("There is no subset of {0} elements with sum {1}.", k, sumS);
                    }
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

