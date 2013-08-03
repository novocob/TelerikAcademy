/*  11. Write a program that finds the index of given element 
 *  in a sorted array of integers by using the binary search algorithm. */

using System;
class BinarySearch
{
    static void Main()
    {
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
        foreach (int i in arr)
        {
            Console.Write("{0}, ",i);
        }
        Console.WriteLine();
        Console.Write("Enter a number from the printed array: ");
        int num = int.Parse(Console.ReadLine());

        int currentIndex = arr.Length / 2;
        int currentLength = arr.Length;
        int endIndex = arr.Length;

        while (currentLength>0)
        {
           currentLength =(currentLength+1)/ 2;
           if (arr[currentIndex] == num)
           {
               break;
           }
           else if (arr[currentIndex] > num)
           {
               currentIndex = currentIndex - (currentLength + 1 ) / 2;
           }
           else if (arr[currentIndex] < num)
           {
               currentIndex = currentIndex + currentLength/2;
           }
        }
        Console.WriteLine("The index of number {0} is {1}",num, currentIndex);
        
    }
}

