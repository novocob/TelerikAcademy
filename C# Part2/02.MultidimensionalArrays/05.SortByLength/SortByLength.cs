/* 05.You are given an array of strings. 
 * Write a method that sorts the array by the length of 
 * its elements (the number of characters composing them).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Matrix05
{
    class Program
    {
        static void Main()
        {
            string[] InputArray = { "word", "b", "pencil", "car", "sky", "river" };

            int minLength = int.MaxValue;
            string minString = "";
            int minIndex = 0;

            // sort the array using selection sort algorithm
            for (int i = 0; i < InputArray.Length; i++)
            {
                for (int j = i; j < InputArray.Length; j++) //in this loop we find the shortest string
                {                                           //among the unsorted elements
                    if (InputArray[j].Length <= minLength)
                    {
                        minLength = InputArray[j].Length;
                        minString = InputArray[j];
                        minIndex = j;
                    }
                }
                string temp = InputArray[i];                //here we move the shortest string at the
                InputArray[i] = InputArray[minIndex];       //first position among the unsorted elements
                InputArray[minIndex] = temp;

                minLength = int.MaxValue;
                minString = "";
            }
            foreach (string sorted in InputArray)
            {
                Console.WriteLine(sorted);
            }
        }
    }
}