/* 03.Write a program that reads a text file 
 *    and inserts line numbers in front of each of its lines. 
 *    The result should be written to another text file. */

using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        //I will use the .cs file and its directory for output file
        StreamReader inputFile = new StreamReader("../../InsertLineNumbers.cs");
        StreamWriter outputFile = new StreamWriter("../../FileWithLineNumbers.txt");
        using (inputFile)
        {
            using (outputFile)
            {
                int lineNumber = 1;
                string currentStringLine = inputFile.ReadLine();
                while (currentStringLine != null)
                {
                    outputFile.WriteLine("Line {0}: {1}", lineNumber, currentStringLine);
                    lineNumber++;
                    currentStringLine = inputFile.ReadLine();
                }
            }
        }
    }
}

