/* 04.Write a program, that reads from the console 
 * an array of N integers and an integer K, sorts 
 * the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Matrix04
{
    class Matrix04
    {
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int numN = int.Parse(Console.ReadLine());
            int[] array = new int[numN];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number K: ");
            int numK = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Array.Sort(array);
            int index = Array.BinarySearch(array, numK);

            if (index >= 0)
            {
                Console.WriteLine("The largest number <= K is: {0}", array[index]);
            }
            else if (index == -1)
            {
                Console.WriteLine("There is no number <= K.");
            }
            else
            {
                Console.WriteLine("The largest number <= K is: {0}", array[(~index) - 1]);
            }
        }
    }
}
