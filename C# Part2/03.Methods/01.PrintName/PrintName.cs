/*  Write a method that asks the user for his 
 *  name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 *  Write a program to test this method. */

using System;
class PrintName
{
    static void Main()
    {
        GetAndPrintName();
    }

    static void GetAndPrintName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", userName);
    }
}

