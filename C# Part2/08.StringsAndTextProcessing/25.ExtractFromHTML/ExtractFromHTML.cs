/* 25.Write a program that extracts from given HTML file its title 
 * (if available), and its body text without the HTML tags. Example:
    <html>
    <head><title>News</title></head>
    <body><p><a href="http://academy.telerik.com">TelerikAcademy</a>
        aims to provide free real-world practical
        training for young people who want to turn into
        skillful .NET software engineers.</p></body>
    </html>
 */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        StreamReader reader = new StreamReader("../../HTMLfile.txt");
        bool outsideTags = false;
        int index = 0;
        using (reader)
        {
            string text = reader.ReadToEnd();
            while (index < text.Length)
            {
                if (text[index] == '<')
                {
                    outsideTags = false;
                    index++;
                    continue;
                }
                if (text[index] == '>')
                {
                    outsideTags = true;
                    index++;
                    continue;
                }
                if (outsideTags)
                {
                    sb.Append(text[index]);
                }
                index++;
            }
            Console.WriteLine(sb);
        }
    }
}

