/*Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols. */

using System;

class PrintNumber
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15} - decimal", number);
        Console.WriteLine("{0,15:X} - hexadecimal", number);
        Console.WriteLine("{0,15:P} - percentage", number);
        Console.WriteLine("{0,15:E} - scientific", number);
    }
}
