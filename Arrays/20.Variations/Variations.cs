/* 20. Write a program that reads two numbers N and K
 * and generates all the variations of K 
 * elements from the set [1..N]. */

using System;
class Variations
{
    static void Main()
    {
        Console.Write("N = ");
        int numIterations = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int numLoops = int.Parse(Console.ReadLine());

        int[] loops = new int[numLoops];
        Variation(0, numIterations, loops);
    }
    static void Variation(int currentLoop, int numIterations, int[] loops)
    {
        if (currentLoop == loops.Length)
        {
            PrintLoops(loops.Length, loops);
            return;
        }
        for (int counter=1; counter<=numIterations; counter++)
        {
            loops[currentLoop] = counter;
            Variation(currentLoop + 1, numIterations, loops);
        }
    }
    static void PrintLoops(int numLoops, int[]loops)
    {
        for (int i = 0; i < numLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}


