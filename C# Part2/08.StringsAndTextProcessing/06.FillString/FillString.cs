﻿/*06. Write a program that reads from the console a string of maximum 20 characters. 
 *    If the length of the string is less than 20, the rest of the characters 
 *    should be filled with '*'. Print the result string into the console. */

using System;

class FillString
{
    static void Main()
    {
        Console.WriteLine("Enter a string of maximum 20 characters : ");
        string inputString = Console.ReadLine();
        Console.WriteLine(inputString.PadRight(20,'*'));
    }
}

