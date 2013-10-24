/* 11.Write a program that deletes from a text file 
 *    all words that start with the prefix "test". 
 *    Words contain only the symbols 0...9, a...z, A…Z, _. */

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteTestWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\InputFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\OutputFile.txt");
        using (reader)
        {
            using (writer)
            {
                string currentLine = reader.ReadLine();
                string modifiedLine;
                string pattern = @"\btest[0-9A-Za-z_]*\b";
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                while (currentLine != null)
                {
                    modifiedLine = rgx.Replace(currentLine, String.Empty);
                    writer.WriteLine(modifiedLine);
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}