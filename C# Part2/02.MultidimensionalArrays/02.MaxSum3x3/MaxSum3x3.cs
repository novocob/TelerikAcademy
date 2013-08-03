/* 02. Write a program that reads a rectangular matrix 
 * of size N x M and finds in it the square 3 x 3 
 * that has maximal sum of its elements.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace temp
{
    class Matrix02
    {
        static void Main()
        {
            int[,] matrix =
            {
            {5, 8, 2, 10, 3, 4, 1},
            {3, 12, 4, 6, 2, 15, 7},
            {3, 1, 7, 11, 9, 2, 6},
            {4, 13, 5, 12, 1, 9, 3},
            {6, 5, 3, 14, 7, 8, 1}
            };
            int currentSum = 0;
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j <= col + 2; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }
                    if (currentSum >= bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine("The best square 3x3 is:");
            for (int row = bestRow; row <= bestRow + 2; row++)
            {
                for (int col = bestCol; col <= bestCol + 2; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum of his elements is: {0}", bestSum);
        }
    }
}
