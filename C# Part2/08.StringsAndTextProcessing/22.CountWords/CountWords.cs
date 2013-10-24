/* 22. Write a program that reads a string from the console 
 *     and lists all different words in the string along with 
 *     information how many times each word is found.   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountWords
{
    static void Main()
    {
        Console.WriteLine("Enter a string :");
        string text = Console.ReadLine();
        char[] separators = new char[] { ' ', '.', ',', '!', '?', '-' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (!dict.ContainsKey(word))
            {
                dict.Add(word, 1);
            }
            else
            {
                dict[word] += 1;
            }
        }
        foreach (var pair in dict)
        {
            Console.WriteLine("\"{0}\" is found {1} times.", pair.Key, pair.Value);
        }
    }
}
