/* 23. Write a program that reads a string from the console 
 *     and replaces all series of consecutive identical letters 
 *     with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa". */

using System;
using System.Text;

class ReplaceIdenticalLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a string :");
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder(text);
        int index = 1;
        while (index < sb.Length)
        {
            if (sb[index] == sb[index - 1])
            {
                sb.Remove(index, 1);
            }
            else
            {
                index++;
            }
        }
        Console.WriteLine(sb);
    }
}
