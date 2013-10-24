/* 07.Write a program that encodes and decodes a string using 
 * given encryption key (cipher). The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR (exclusive or) 
 * operation over the first letter of the string with the first of the key, 
 * the second – with the second, etc. When the last key character 
 * is reached, the next is the first. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecodeString
{
    static void Main()
    {
        Console.WriteLine("This text will be encoded and decoded:");
        string text = "Red Hot Chili Peppers";
        Console.WriteLine(text);
        string key = "code42";
        Console.WriteLine("This is the key:");
        Console.WriteLine(key);
        Console.WriteLine();

        string encodedText = EncodeDecode(text, key);
        Console.WriteLine("Encoded text:");
        Console.WriteLine(encodedText);
        Console.WriteLine();

        string decodedText = EncodeDecode(encodedText, key);
        Console.WriteLine("Decoded text:");
        Console.WriteLine(decodedText);
        Console.WriteLine();
    }

    static string EncodeDecode(string text, string key)
    {
        int indexText = 0;
        StringBuilder sb = new StringBuilder();
        bool checkLength = true;
        while (checkLength)
        {
            for (int i = 0; i < key.Length; i++)
            {
                sb.Append((char)(text[indexText] ^ key[i]));
                indexText++;
                if (indexText == text.Length)
                {
                    checkLength = false;
                    break;
                }
            }
        }
        return sb.ToString();
    }
}

