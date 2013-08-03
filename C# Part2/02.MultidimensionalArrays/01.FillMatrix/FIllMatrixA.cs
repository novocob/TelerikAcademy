/* 01.a) Write a program that fills and prints
 * a matrix of size (n, n)*/

using System;
class FIllMatrixA
{
    static void Main()
    {
        Console.Write("Enter the size of matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int count = 1;

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,4}",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
