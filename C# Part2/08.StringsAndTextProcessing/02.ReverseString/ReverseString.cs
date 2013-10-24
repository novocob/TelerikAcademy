/* 02. Write a program that reads a string, 
 *     reverses it and prints the result at the console.
       Example: "sample"  "elpmas". */

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string inputString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            sb.Append(inputString[i]);
        }
        Console.WriteLine("Reversed string is : {0}", sb);
    }
}
