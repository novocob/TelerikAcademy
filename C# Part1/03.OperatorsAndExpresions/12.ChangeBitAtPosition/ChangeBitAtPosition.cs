/*  We are given integer number n, value v (v=0 or 1) 
    and a position p. Write a sequence of operators that 
    modifies n to hold the value v at the position p 
    from the binary representation of n. */

using System;
class ChangeBitAtPosition
{
    static void Main()
    {
        Console.Write("Input number n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input value v (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Input bit position p : ");
        int p = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int modifiedNumber = n & mask;
            Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}", n, p, v, modifiedNumber);
        }
        else
        {
            int mask = 1 << p;
            int modifiedNumber = n | mask;
            Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}", n, p, v, modifiedNumber);
        }
    }
}

