/* 07. Write a program that replaces all occurrences
 *     of the substring "start" with the substring "finish"
 *     in a text file. Ensure it will work with large files (e.g. 100 MB). */

using System;
using System.IO;

class ReplaceStartWithFinish
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\InputFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\TempFile.txt");
        using (reader)
        {
            using (writer)
            {
                string currentLine = reader.ReadLine();
                string modifiedLine;
                while (currentLine != null)
                {
                    modifiedLine = currentLine.Replace("start", "finish");
                    writer.WriteLine(modifiedLine);
                    currentLine = reader.ReadLine();
                }
            }
        }
        //the task is to modify the original .txt file, so I overwrite the
        //original InputFile.txt with TempFile.txt, and then delete TempFile.txt
        File.Delete(@"..\..\InputFile.txt");
        File.Copy(@"..\..\TempFile.txt", @"..\..\InputFile.txt");
        File.Delete(@"..\..\TempFile.txt");
    }
}

