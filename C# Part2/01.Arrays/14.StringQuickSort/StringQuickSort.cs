/* 14. Write a program that sorts an array of strings 
 * using the quick sort algorithm (find it in Wikipedia).   */

using System;
using System.Collections.Generic;
class StringQuickSort
{
    static void Main()
    {
        List<string> arr = new List<string>();  
        InputArr(arr);                          // inputs the strings in the list
        SortArr(arr);                           // sorts the string in the list using the quick sort algorithm
        PrintArr(arr);                          // prints the sorted list
    }

    // inputs the strings in the list
    static List<string> InputArr(List<string> arr)
    {
        while (true)
        {
            Console.WriteLine("Enter new string element or press \"enter\" to finish : ");
            string temp = Console.ReadLine();
            if (temp == "")
            {
                break;
            }
            arr.Add(temp);
        }
        return arr;
    }

    // sorts the string in the list using the quick sort algorithm
    static List<string> SortArr(List<string> arr)
    {
        if (arr.Count <= 1) return arr;                 // the base case of recursion (bottom)
        string pivot = arr[arr.Count / 2];              // pivot is the string which will devide the list in two parts
        List<string> leftPart = new List<string>();     // put strings lexicographically smaller then pivot here
        List<string> rightPart = new List<string>();    // put strings lexicographically bigger then pivot here
        
        for (int i = 0; i < arr.Count; i++)
        {
            if (i == arr.Count / 2)
            {
                continue;
            }
            else if (string.Compare(arr[i], pivot) <= 0)
            {
                leftPart.Add(arr[i]);
            }
            else
            {
                rightPart.Add(arr[i]);
            }
        }
        SortArr(leftPart);
        SortArr(rightPart);

        // put together the leftPart, pivot and the rightPart in one list
        arr.Clear();                
        arr.AddRange(leftPart);
        arr.Add(pivot);
        arr.AddRange(rightPart);

        return arr;
    }

    // prints the sorted list  
    static void PrintArr(List<string> arr)
    {
        for (int k = 0; k < arr.Count; k++)
        {
            Console.WriteLine(arr[k]);
        }
    }
}

