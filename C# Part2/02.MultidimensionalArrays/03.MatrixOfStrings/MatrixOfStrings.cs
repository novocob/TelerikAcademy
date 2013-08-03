/* 03. We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor 
 * elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence 
 * of equal strings in the matrix. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Matrix03
{
    class Matrix03
    {
        static void Main(string[] args)
        {
            string[,] matrix =
            {
            {"a", "a", "c", "d", "e"},
            {"f", "g", "h", "i", "j"},
            {"k", "l", "m", "n", "o"},
            {"p", "q", "r", "s", "t"},
            };

            int count = 1;              //here will keep the number of strings in the current sequence
            int bestCount = 0;          //here will keep the number of strings in the longest sequence
            string bestString = "";     //here will keep the string of the longest sequence

            // check vertikals
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row, col]);
                        }
                    }
                }
                if (count >= bestCount)
                {
                    bestCount = count;
                    count = 1;
                    bestString = (matrix[matrix.GetLength(0) - 1, col]);
                }
                count = 1;
            }

            // check horizontals
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row, col]);
                        }
                    }
                }
                if (count >= bestCount)
                {
                    bestCount = count;
                    count = 1;
                    bestString = (matrix[row, matrix.GetLength(1) - 1]);
                }
                count = 1;
            }


            // check diagonals TopLeft - BottomRight
            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {

                int col = 0;
                for (int i = 0; i < matrix.GetLength(0) - row - 1; i++)
                {
                    if ((row + i + 1 > matrix.GetLength(0) - 1) || (col + i + 1 > matrix.GetLength(1) - 1))
                    {
                        continue;
                    }
                    if (matrix[row + i, col + i] == matrix[row + i + 1, col + i + 1])
                    {
                        count++;
                        if ((count >= bestCount) && ((row + i + 1 == matrix.GetLength(0) - 1) || (col + i + 1 == matrix.GetLength(1) - 1)))
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col + i]);
                        }
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col + i]);
                        }
                    }
                }
                count = 1;
            }

            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int row = 0;
                for (int i = 0; i < matrix.GetLength(0) - row - 1; i++)
                {
                    if ((row + i + 1 > matrix.GetLength(0) - 1) || (col + i + 1 > matrix.GetLength(1) - 1))
                    {
                        continue;
                    }
                    if (matrix[row + i, col + i] == matrix[row + i + 1, col + i + 1])
                    {
                        count++;
                        if ((count >= bestCount) && ((row + i + 1 == matrix.GetLength(0) - 1) || (col + i + 1 == matrix.GetLength(1) - 1)))
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col + i]);
                        }
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col + i]);
                        }
                    }
                }
                count = 1;
            }

            // check diagonals BottomLeft - TopRight
            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {

                int col = matrix.GetLength(1) - 1;
                for (int i = 0; i < matrix.GetLength(0) - row - 1; i++)
                {
                    if ((row + i + 1 > matrix.GetLength(0) - 1) || (col - i - 1 < 0))
                    {
                        continue;
                    }
                    if (matrix[row + i, col - i] == matrix[row + i + 1, col - i - 1])
                    {
                        count++;
                        if ((count >= bestCount) && ((row + i + 1 == matrix.GetLength(0) - 1) || (col + i - 1 == 0)))
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col - i]);
                        }
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col - i]);
                        }
                    }
                }
                count = 1;
            }


            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                int row = 0;
                for (int i = 0; i < matrix.GetLength(0) - row - 1; i++)
                {
                    if ((row + i + 1 > matrix.GetLength(0) - 1) || (col - i - 1 < 0))
                    {
                        continue;
                    }
                    if (matrix[row + i, col - i] == matrix[row + i + 1, col - i - 1])
                    {
                        count++;
                        if ((count >= bestCount) && ((row + i + 1 == matrix.GetLength(0) - 1) || (col - i - 1 == 0)))
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col - i]);
                        }
                    }
                    else
                    {
                        if (count >= bestCount)
                        {
                            bestCount = count;
                            count = 1;
                            bestString = (matrix[row + i, col - i]);
                        }
                    }
                }
                count = 1;
            }

            //print result
            Console.WriteLine("The longest sequence is:");
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write("{0} ", bestString);
            }
            Console.WriteLine();
        }
    }
}
