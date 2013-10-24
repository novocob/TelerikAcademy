/* 08. Write a program that extracts from a 
       given text all sentences containing given word. */

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string resultText="";
        bool containsIn;
        string[] sentences = Regex.Split(text, @"\.");
        foreach (string sentence in sentences)
        {
            containsIn = Regex.IsMatch(sentence, @"\bin\b", RegexOptions.IgnoreCase);
            if (containsIn)
            {
                resultText += sentence + ".";
            }
            containsIn = false;
        }
        Console.WriteLine(resultText);
    }
}

