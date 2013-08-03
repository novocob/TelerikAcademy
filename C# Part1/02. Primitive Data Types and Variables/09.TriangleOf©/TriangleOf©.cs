/*  Write a program that prints an isosceles triangle of 9 copyright 
    symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. 
    Note: the © symbol may be displayed incorrectly. */
 

using System;
using System.Text;
class TriangleOfCopyrigtSymbol
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = (char)64;
        Console.WriteLine("   {0}", copyright);
        Console.WriteLine("  {0} {0}", copyright);
        Console.WriteLine(" {0}   {0}", copyright);
        Console.WriteLine("{0} {0} {0} {0}", copyright);
    }
}

