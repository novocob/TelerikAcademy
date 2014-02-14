/*  Write a boolean expression for finding if 
    the bit 3 (counting from 0) of a given integer is 1 or 0. */


using System;
class ThirdBit
{
    static void Main()
    {
        Console.Write("Input number: ");
        int num = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int numAndMask = num & mask;
        int bit = numAndMask >> 3;
        Console.WriteLine("The third bit is {0}", bit);
    }
}

