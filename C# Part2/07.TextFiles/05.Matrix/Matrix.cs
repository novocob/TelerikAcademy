/* 05. Write a program that reads a text file containing a square matrix 
 *     of numbers and finds in the matrix an area of size 2 x 2 with 
 *     a maximal sum of its elements. The first line in the input file 
 *     contains the size of matrix N. Each of the next N lines contain 
 *     N numbers separated by space. The output should be a single number 
 *     in a separate text file. */

using System;
using System.IO;

class Matrix
{
    static void Main()
    {
        int[,] matrix = ReadAndParseMatrix();
        int bestSum = FindBestSum(matrix);
        WriteInFile(bestSum);
    }

    static int[,] ReadAndParseMatrix()
    {
        //I will put the .txt files in the same directory as .cs file
        StreamReader reader = new StreamReader(@"..\..\Matrix.txt");
        using (reader)
        {
            int size = int.Parse(reader.ReadLine());
            int[,] matrix = new int[size, size];
            string[] separators = new string[] { " " };
            string[] currentLineOfMatrix;
            string currentLine;
            //for every line in Matrix.txt the code reads the line, splits it in string array
            //and then copies parsed values from string array to int array
            for (int i = 0; i < size; i++)
            {
                currentLine = reader.ReadLine();
                currentLineOfMatrix = currentLine.Split(separators, StringSplitOptions.None);
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(currentLineOfMatrix[j]);
                }
            }
            return matrix;
        }
    }

    static int FindBestSum(int[,] matrix)
    {
        int bestSum = 0;
        int currentSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum >= bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }
        return bestSum;
    }

    static void WriteInFile(int bestSum)
    {
        //I will put the result.txt in the same directory as .cs file
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (writer)
        {
            writer.WriteLine(bestSum);
        }
    }
}

