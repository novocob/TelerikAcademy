/* 02. Write a program that reads two arrays from 
 * the console and compares them element by element.*/


using System;
class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter number of elements : ");
        int n = int.Parse(Console.ReadLine());

        string[] firstArray = new string[n];
        string[] secondArray = new string[n];

        Console.WriteLine();
        Console.WriteLine("Enter the elements of the first array.");
        for (int i = 0; i < n; i++)
        {
            Console.Write("firstArray[{0}] = ", i);
            firstArray[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("Enter the elements of the second array.");
        for (int i = 0; i < n; i++)
        {
            Console.Write("secondArray[{0}] = ", i);
            secondArray[i] = Console.ReadLine();
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] = secondArray[{0}] -> true", i);
            }
            else
            {
                Console.WriteLine("firstArray[{0}] = secondArray[{0}] -> false", i);
            }
        }
    }
}

