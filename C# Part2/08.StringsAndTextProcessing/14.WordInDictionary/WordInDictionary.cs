/* 14. A dictionary is stored as a sequence of text lines 
 * containing words and their explanations. Write a program 
 * that enters a word and translates it by using the dictionary.
    Sample dictionary:
        .NET - platform for applications from Microsoft
        CLR - managed execution environment for .NET
        namespace - hierarchical organization of classes */

using System;
using System.Collections.Generic;

class WordInDictionary
{
    static void Main()
    {
        string firstLine = @".NET - platform for applications from Microsoft
                             CLR - managed execution environment for .NET
                             namespace - hierarchical organization of classes";
        IDictionary<string, string> dict = new Dictionary<string, string>();
        string[] lines = firstLine.Split('\n');             //splits the text to separate lines
        string[] words = new string[lines.Length];
        string[] explanations = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();
            int index = lines[i].IndexOf(" - ");                //finds where is the end of the word
            words[i] = lines[i].Substring(0, index);            //extracts the word form a line
            explanations[i] = lines[i].Substring(index + 3);    //extracts the explanation form a line
            dict.Add(words[i], explanations[i]);                //adds to dictionary the key and the value
        }

        Console.WriteLine("Enter a word from the dictionary (.NET, CLR or namespace) : ");
        string inputWord = Console.ReadLine();
        Console.WriteLine(dict[inputWord]);
    }
}