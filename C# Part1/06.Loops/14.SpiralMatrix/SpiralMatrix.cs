/*  * Write a program that reads a positive integer number N (N < 20) 
 * from console and outputs in the console the numbers 1 ... N 
 * numbers arranged as a spiral.    */

using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter positive integer number N <20 : ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int value = 1;          // Value of matrix[row,col]
        int direction = 1;      // 1 - move right, 2 - move down, 3 - move left, 4 - move up
        int row = 0;            // matrix[row,col]
        int col = 0;            // matrix[row,col]
        int maxRow = n - 1;     // bottom boundary
        int maxCol = n - 1;     // right boundary
        int minRow = 1;         // top boundary
        int minCol = 0;         // left boundary

        while (value <= (n * n))  //move through the array  and initialize all matrix[row,col]
        {
            switch (direction)
            {
                case 1: // move right
                    matrix[row, col] = value;
                    col += 1;
                    value += 1;
                    if (col == maxCol) // if we reach boundary we change movement direction and we change the value of boundary
                    {                   
                        direction = 2;
                        maxCol -= 1;
                    }
                    break;
                case 2: // move down
                    matrix[row, col] = value;
                    row += 1;
                    value += 1;
                    if (row == maxRow)
                    {
                        direction = 3;
                        maxRow -= 1;
                    }
                    break;
                case 3: // move left
                    matrix[row, col] = value;
                    col -= 1;
                    value += 1;
                    if (col == minCol)
                    {
                        direction = 4;
                        minCol += 1;
                    }
                    break;
                case 4: // move up
                    matrix[row, col] = value;
                    row -= 1;
                    value += 1;
                    if (row == minRow)
                    {
                        direction = 1;
                        minRow += 1;
                    }
                    break;
            }
        }
        for (int i = 0; i < n; i++) // printing on the console
        {
            for (int J = 0; J < n; J++)
            {
                Console.Write("{0,4}",matrix[i,J]);
            }
            Console.WriteLine();
        }
    }
}

