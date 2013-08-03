/* Write a method that returns the index 
 * of the first element in array that is bigger 
 * than its neighbors, or -1, if there’s no such element.
   Use the method from the previous exercise.*/

using System;
class FirstBiggerNumber
{
    static void Main()
    {
        int[] numbers = new int[] { 3, 1, 5, 7, 6, 9, 1, 2 };
        Console.WriteLine("These are the elements in the array:");
        foreach (int num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();

        int result = SearchBiggerElement(numbers);

        if (result == -1)
        {
            Console.WriteLine("There is no element bigger than its neigbours.");
        }
        else
        {
            Console.WriteLine("The first element bigger than its neigbours is at position {0}.", result);
        }
    }


    static int SearchBiggerElement(int[] arr)    //this method searches the first element bigger than its neighbours
    {                                            //returns the index of the element, or returns -1 if there is no such element
        for (int index = 1; index < arr.Length - 2; index++)
        {
            bool check = CheckNeigbours(arr, index);
            if (check == true)
            {
                return index;
            }
        }
        return -1;
    }

    static bool CheckNeigbours(int[] arr, int position)         // this is the method from task 05, it checks if the element
    {                                                           // at given position is bigger than its neighbours
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

