/* 01.Write a program that reads a text file 
 *    and prints on the console its odd lines. */

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../PrintOddLines.cs");
        using (reader)
        {
            int lineNumber = 1;
            string textLine = reader.ReadLine();
            while (textLine != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, textLine);
                }
                lineNumber++;
                textLine = reader.ReadLine();
            }
        }
    }
}

