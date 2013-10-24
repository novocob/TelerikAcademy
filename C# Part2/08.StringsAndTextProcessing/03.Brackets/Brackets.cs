/* 03. Write a program to check if in a 
 *    given expression the brackets are put correctly.
      Example of correct expression: ((a+b)/5-d).
      Example of incorrect expression: )(a+b)). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Brackets
{
    static void Main()
    {
        Console.Write("Enter an expression with brackets : ");
        string expression = Console.ReadLine();
        int leftBrackets = 0;
        int rightBrackets = 0;
        bool correctBrackets = true;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                leftBrackets++;
            }
            if (expression[i] == ')')
            {
                rightBrackets++;
            }
            if (leftBrackets < rightBrackets)
            {
                correctBrackets = false;
                break;
            }
        }
        if (leftBrackets > rightBrackets)
        {
            correctBrackets = false;
        }
        Console.WriteLine(correctBrackets ? "The brackets are correct." : "The brackets are not correct.");
    }
}
