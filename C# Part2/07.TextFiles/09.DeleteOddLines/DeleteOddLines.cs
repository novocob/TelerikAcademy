/* 09. Write a program that deletes from given text file 
 *     all odd lines. The result should be in the same file. */

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\IO_File.txt");
        List<string> lines = new List<string>(); //here will put all even lines
        using (reader)
        {
            int countLines = 1;
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                if (countLines % 2 == 0)
                {
                    lines.Add(currentLine);
                }
                countLines++;
                currentLine = reader.ReadLine();
            }
        }
        //write the even lines back to the file
        StreamWriter writer = new StreamWriter(@"..\..\IO_File.txt");
        using (writer)
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}

