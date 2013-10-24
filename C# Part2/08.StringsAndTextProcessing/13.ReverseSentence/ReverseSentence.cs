/* 13.Write a program that reverses the words in given sentence. 
 * Example:
    C# is not C++, not PHP and not Delphi!
    Delphi not and PHP, not C++ not is C#! */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReverseSentence
{
    static void Main()
    {
        string inputSentence = "C# is not C++, not PHP and not Delphi!";
        string pattern = @"\s+|,\s*|-\s*|\.\s*|!\s*|\?\s*";
        List<string> words = new List<string>();
        List<string> separators = new List<string>();

        foreach (string word in Regex.Split(inputSentence, pattern))
        {
            words.Add(word);
        }
        foreach (Match separator in Regex.Matches(inputSentence, pattern))
        {
            separators.Add(separator.Value);
        }
        words.Reverse();
        StringBuilder reversedSentence = new StringBuilder();
        int index = 0;
        while ((index < words.Count) && (index < separators.Count))
        {
            reversedSentence.Append(words[index]);
            reversedSentence.Append(separators[index]);
            index++;
        }
        Console.WriteLine(reversedSentence);
    }
}