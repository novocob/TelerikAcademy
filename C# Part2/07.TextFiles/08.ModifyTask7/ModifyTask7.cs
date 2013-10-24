/* 08. Modify the solution of the previous problem 
 *     to replace only whole words (not substrings). */

using System;
using System.IO;
using System.Text.RegularExpressions;

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
                    modifiedLine = Regex.Replace(currentLine, @"\bstart\b", "finish");
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

