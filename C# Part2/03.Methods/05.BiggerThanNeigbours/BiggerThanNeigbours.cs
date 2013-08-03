/* Write a method that checks if the element 
 * at given position in given array of integers is 
 * bigger than its two neighbors (when such exist).*/

using System;
class BiggerThanNeigbours
{
    static void Main()
    {
        int[] numbers = new int[] { 5, 1, 7, 5, 10, 10, 6, 8, 2 };
        Console.WriteLine("These are the elements in the array:");
        foreach (int num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.Write("Enter position in range (1-{0}): ", (numbers.Length - 2));
        int position = int.Parse(Console.ReadLine());
        

        bool check = CheckNeigbours(numbers, position);
        if (check == true)
        {
            Console.WriteLine("The number at position {0} is bigger than its two neigbours.", position);
        }
        else
        {
            Console.WriteLine("The number at position {0} is not bigger than ", position);
            Console.WriteLine("its two neigbours or there are no two neigbours.");
        }
    }

    static bool CheckNeigbours(int[] arr, int position)
    {
        if ((position == 0) || (position == arr.Length - 1))
        {
            return false;
        }
        else if ((arr[position] > arr[position - 1]) && (arr[position] > arr[position + 1]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

