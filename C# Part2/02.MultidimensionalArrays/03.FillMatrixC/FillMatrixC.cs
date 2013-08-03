/* 01.c) Write a program that fills and prints
 * a matrix of size (n, n)*/

using System;
class FillMatrixC
{
    static void Main()
    {
        Console.Write("Enter the size of matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int count = 1;

        for (int row = size - 1; row >= 0; row--)
        {
            int newRow = row;
            int newCol = 0;
            while ((newRow < size) && (newCol<size))
            {
                matrix[newRow, newCol] = count;
                count++;
                newRow++;
                newCol++;
            }
        }

        for (int col = 1; col < size; col++)
        {
            int newRow = 0;
            int newCol = col;
            while ((newRow < size) && (newCol < size))
            {
                matrix[newRow, newCol] = count;
                count++;
                newRow++;
                newCol++;
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

