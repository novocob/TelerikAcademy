/* Write a method that return the maximal element 
 * in a portion of array of integers starting at 
 * given index. Using it write another method that 
 * sorts an array in ascending / descending order.*/

using System;
class SortArray
{
    static void Main()
    {
        int[] arr = new int[]{5, 2, 8, 10, 3, 1, 4, 7, 6, 9};   //this array will be sorted
        Console.Write("Choose an order - input \"a\" for ascending or \"d\" for descending order: ");
        string order = Console.ReadLine();
        if (order == "a")
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int indexMaxElement = FindMaxElementIndex(arr, 0, i);
                SwapElements(arr, indexMaxElement, i);
            }
        }
        else if (order == "d")
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int indexMaxElement = FindMaxElementIndex(arr, i, arr.Length - 1);
                SwapElements(arr, indexMaxElement, i);
            }
        }
        else return;

        foreach (int i in arr)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }

    //this method finds the index of the max element in the range startIndex-endIndex
    static int FindMaxElementIndex(int[] array, int startIndex, int endIndex)
    {
        int bestIndex = startIndex;
        int maxElement = int.MinValue;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                bestIndex = i;
            }
        }
        return bestIndex;
    }

    //this method changes the positions of the max element and first or last of the unsorted elements
    static void SwapElements(int[] array, int indexMaxElement, int currentIndex)
    {
        int temp = array[currentIndex];
        array[currentIndex] = array[indexMaxElement];
        array[indexMaxElement] = temp;
        return;
    }
}

