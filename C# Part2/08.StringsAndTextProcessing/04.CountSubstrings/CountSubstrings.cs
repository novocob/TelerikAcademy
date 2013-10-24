/* 04. Write a program that finds how many times 
 *     a substring is contained in a given text 
 *     (perform case insensitive search). */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CountSubstrings
{
    static void Main()
    {

        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        text = text.ToLower();
        int index = text.IndexOf(substring);
        int count = 0;
        while (index != -1)
        {
            count++;
            index = text.IndexOf("in", index + 1);
        }
        Console.WriteLine(count);
        

        // A solution with Regex:
      /*
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int count = Regex.Matches(text, "in", RegexOptions.IgnoreCase).Count;
        Console.WriteLine(count); 
      */
        
    }
}