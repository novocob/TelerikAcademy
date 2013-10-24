/* 18.Write a program for extracting all email addresses from given text. 
      All substrings that match the format <identifier>@<host>…<domain> 
      should be recognized as emails. */

using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main()
    {
        string inputText = @"Please contact us by phone (+359 222 222 222) or 
                            by email at exa_mple@abv.bg or at baj-ivan@yahoo.co.uk. 
                            This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string[] expressions = inputText.Split(' ');

        Console.WriteLine("Valid emails:");
        for (int i = 0; i < expressions.Length; i++)
        {
            if (Regex.IsMatch(expressions[i], @"\w+@[\w]{2,20}[.]{1}\w+"))
            {
                Console.WriteLine(expressions[i]);
            }
        }
    }
}