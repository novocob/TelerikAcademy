/* 01.d) Write a program that fills and prints
 * a matrix of size (n, n)*/

using System;
class FillMatrixD
{
    static void Main()
    {
        Console.Write("Enter the size of matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int row = 0;
        int col = 0;
        string direction = "down";
        int bottom = size - 1;      //this is the bottom boundary
        int top = 0;                //this is the top boundary 
        int left = 1;               //this is the left boundary 
        int right = size - 1;       //this is the right boundary 

        matrix[0,0]=1;
        for (int count = 2; count <=size*size; count++) //in this loop we initialzie the elements of the matrix
        {
            switch(direction)                           //with the numbers from 2 to size*size
            {
                case "down":
                    row++;
                    matrix[row, col] = count;
                    if (row == bottom)      //when we reach bottom boundary we change the direction
                    {
                        direction = "right";
                        bottom--;           //the bottom bounday moves one row up
                    }
                    break;

                case "right":
                    col++;
                    matrix[row, col] = count;
                    if (col == right)       //when we reach right boundary we change the direction
                    {
                        direction = "up";
                        right--;            //the right bounday moves one column left
                    }
                    break;

                case "up":
                    row--;
                    matrix[row, col] = count;
                    if (row == top)         //when we reach top boundary we change the direction
                    {
                        direction = "left";
                        top++;               //the top bounday moves one row down
                    }
                    break;

                case "left":
                    col--;
                    matrix[row, col] = count;
                    if (col == left)        //when we reach left boundary we change the direction
                    {
                        direction = "down";
                        left++;             //the left bounday moves one column right
                    }
                    break;
            }
        }

        for (row = 0; row < size; row++)
        {
            for (col = 0; col < size; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

