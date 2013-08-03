/*  Write an expression that extracts from a given integer 
    i the value of a given bit number b. Example: i=5; b=2  value=1.  */


using System;
class Program
{
    static void Main()
    {
        Console.Write("Input number i : ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Input bit number b : ");
        int b = int.Parse(Console.ReadLine());

        int bit = ((i >> b) & 1);
        Console.WriteLine("The value of bit number {0} is : {1}", b, bit);
    }
}

