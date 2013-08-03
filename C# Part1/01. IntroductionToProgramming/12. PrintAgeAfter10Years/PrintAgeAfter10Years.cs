// 12. Write a program to read your age from the console and print how old you will be after 10 years.

using System;
class PrintAgeAfter10Years
{
    static void Main()
    {
        Console.Write("What is your age?: ");
        string ageString = Console.ReadLine();
        byte age = byte.Parse(ageString);
        Console.WriteLine("Your age after 10 years will be: " + (age+10));
    }
}

