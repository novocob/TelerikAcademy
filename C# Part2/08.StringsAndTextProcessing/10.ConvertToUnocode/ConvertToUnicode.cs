/*10.Write a program that converts a string to a sequence 
 * of C# Unicode character literals. Use format strings. */

using System;
using System.Text;

class ConvertToUnicode
{
    static void Main()
    {
        Console.Write("Enter string : ");
        string inputString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < inputString.Length; i++)
        {
            int code = (int)inputString[i];
            sb.AppendFormat("\\u{0:x4}", code);
        }
        Console.WriteLine(sb);
    }
}

