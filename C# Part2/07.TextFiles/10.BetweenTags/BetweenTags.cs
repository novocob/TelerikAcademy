/* 10. Write a program that extracts from given 
 *     XML file all the text without the tags. */

using System;
using System.IO;
using System.Linq;
using System.Text;

class BetweenTags
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\InputFile.xml");
        using (reader)
        {
            bool outsideTheTags = false;
            int currentChar = reader.Read(); //reads the next char, returns int
            while (currentChar != -1) // currentChar = -1 in the end of the file
            {
                if (currentChar == 62) // if ">" we come out of the tags
                {
                    outsideTheTags = true;
                    currentChar = reader.Read();
                }
                if (currentChar == 60) // if "<" we come in the tags
                {
                    outsideTheTags = false;
                    currentChar = reader.Read();
                }
                if (outsideTheTags) // if we are outside the tags we print the text
                {
                    Console.Write((char)currentChar);
                    currentChar = reader.Read();
                }
                else
                {
                    currentChar = reader.Read();
                }
            }
        }
    }
}

