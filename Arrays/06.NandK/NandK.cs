/* 06. Write a program that reads two integer numbers N and K 
 * and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.   */

using System;
class NandK
{
    static void Main()
    {
        Console.Write("Enter number N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K : ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] array = new int[n];
        Console.WriteLine("Enter the elements of array.");
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int sum = 0;
        Console.Write("The biggest  K elements are: ");
        for (int i = n-1; i > n-1-k; i--)
        {
            sum += array[i];
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is {0}", sum);
    }
}

