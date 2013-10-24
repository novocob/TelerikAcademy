/* 24.Write a program that reads a list of words, 
 *    separated by spaces and prints the list in an alphabetical order. */

using System;

namespace _24.PrintListOfWords
{
    class PrintListOfWords
    {
        static void Main()
        {
            string listOfWords = "call tree car auto program";
            string[] words = listOfWords.Split(' ');
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
