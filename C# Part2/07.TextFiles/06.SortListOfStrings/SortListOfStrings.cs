/* 06. Write a program that reads a text file
 *     containing  a list of strings, sorts them 
 *     and saves them to another text file. */

using System;
using System.IO;
using System.Collections.Generic;

class SortListOfStrings
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\ListOfStrings.txt");
        List<string> unsortedList = new List<string>();
        using (reader)
        {
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                unsortedList.Add(currentLine);
                currentLine = reader.ReadLine();
            }
        }
        unsortedList.Sort();

        StreamWriter writer = new StreamWriter(@"..\..\SortedList.txt");
        using (writer)
        {
            foreach (string str in unsortedList)
            {
                writer.WriteLine(str);
            }
        }
    }
}

