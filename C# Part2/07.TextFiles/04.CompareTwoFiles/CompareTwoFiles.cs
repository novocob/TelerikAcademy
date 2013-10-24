/* 04.Write a program that compares two text files 
 *    line by line and prints the number of lines 
 *    that are the same and the number of lines that
 *    are different. Assume the files have equal number of lines. */

using System;
using System.IO;

class CompareTwoFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader("../../FirstFile.txt");
        StreamReader secondFile = new StreamReader("../../SecondFile.txt");
        int equalLines = 0;
        int differentLines = 0;
        using (firstFile)
        {
            using (secondFile)
            {
                string lineFirstFile = firstFile.ReadLine();
                string lineSecondFile = secondFile.ReadLine();
                while (lineFirstFile != null)
                {
                    if (lineFirstFile == lineSecondFile)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                    lineFirstFile = firstFile.ReadLine();
                    lineSecondFile = secondFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Equal lines are {0}", equalLines);
        Console.WriteLine("Different lines are {0}", differentLines);
    }
}

