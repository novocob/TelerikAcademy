/*  Write a boolean expression that returns if the bit 
    at position p (counting from 0) in a given integer 
    number v has value of 1. Example: v=5; p=1  false.  */


using System;
class BitAtPositionP
{
    static void Main()
    {
        Console.Write("Input number v : ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Input bit position p : ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int maskAndV = mask & v;
        int bit = maskAndV >> p;
        bool check = (bit == 1);
        Console.WriteLine("v={0}; p={1} -> {2}", v, p, check);
    }
}

