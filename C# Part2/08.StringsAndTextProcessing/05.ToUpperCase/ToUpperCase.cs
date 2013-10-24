/* 05.You are given a text. Write a program that changes 
 * the text in all regions surrounded by the tags <upcase> 
 * and </upcase> to uppercase. The tags cannot be nested. */

 using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ToUpperCase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int length = text.Length;
        string substring;
        int startIndex = 0;
        int firstIndex;
        int secondIndex=-1;
        while (true)
        {
            firstIndex = text.IndexOf("<");
            length = text.Length;
            if ((firstIndex < length - 17)&&(firstIndex > -1))
            {
                secondIndex = text.IndexOf("<", firstIndex + 8);
                substring = text.Substring(firstIndex + 8, secondIndex - firstIndex - 8);
                substring = substring.ToUpper();
                text = text.Substring(startIndex, firstIndex - startIndex) + substring + text.Substring(secondIndex + 9);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(text);
    }
}
