/*  21. Write a program that reads two numbers N and K and 
 *  generates all the combinations of K distinct 
 *  elements from the set [1..N]. */

using System;
class Combinations
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        int[] loops = new int[k];
        int startNumber = 1;
        int currentLoop = 0;
        Combination(loops, n, startNumber, currentLoop);
    }

    static void Combination(int[] loops, int n, int startNumber, int currentLoop)
    {
        if (currentLoop == loops.Length)
        {
            PrintCombination(loops);
            return;
        }
        for (int i = startNumber; i <= n; i++)
        {
            loops[currentLoop] = i;
            Combination(loops, n, i+1, currentLoop+1);
        }
    }
    static void PrintCombination(int[]loops)
    {
        for (int i = 0; i < loops.Length; i++)
        {
            Console.Write("{0} ",loops[i]);
        }
        Console.WriteLine();
    }
}

