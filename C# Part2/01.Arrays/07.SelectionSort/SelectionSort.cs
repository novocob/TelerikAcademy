/* 07. Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc. */

using System;
class SelectionSort
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

        for (int currentIndex = 0; currentIndex < n; currentIndex++)
        {

                // Find the smallest element
            int minValue = int.MaxValue;
            int minIndex = 0;
            for (int i = currentIndex; i < n; i++)
            {
                if (array[i] <= minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }
                // change the position of the smallest element and current element
            int temp = array[currentIndex];
            array[currentIndex] = array[minIndex];
            array[minIndex] = temp;
        }
            // print on the console
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

