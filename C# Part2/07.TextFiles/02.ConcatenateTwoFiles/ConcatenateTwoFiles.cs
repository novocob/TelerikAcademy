/* 02.Write a program that concatenates 
 *    two text files into another text file. */

using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        //I will put the .txt files in the same directory as .cs file
        StreamReader firstReader = new StreamReader("../../FirstFile.txt");
        StreamReader secondReader = new StreamReader("../../secondFile.txt");
        StreamWriter ConcatenatedFile = new StreamWriter("../../ConcatenatedFile.txt", true);
        using (ConcatenatedFile)
        {
            using (firstReader)
            {
                string firstFile = firstReader.ReadToEnd();
                ConcatenatedFile.Write(firstFile);
            }
            using (secondReader)
            {
                string secondFile = secondReader.ReadToEnd();
                ConcatenatedFile.Write(secondFile);
            }
        }

        //print on the console the concatenated file
        StreamReader NewFile = new StreamReader("../../ConcatenatedFile.txt");
        string line = NewFile.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = NewFile.ReadLine();
        }
    }
}

