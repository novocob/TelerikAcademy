/*  13. Write a program that can solve these tasks:
            1.Reverses the digits of a number
            2.Calculates the average of a sequence of integers
            3.Solves a linear equation a * x + b = 0
	    Create appropriate methods.
	    Provide a simple text-based menu for the user to choose which task to solve.
	    Validate the input data:
            1.The decimal number should be non-negative
            2.The sequence should not be empty
            3.a should not be equal to 0  */

using System;
class ThreeTasks
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("    MENU");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("*   1. Reverse the digits of a number.                   *");
            Console.WriteLine("*   2. Calculate the average of a sequence of integers.  *");
            Console.WriteLine("*   3. Solve a linear equation a * x + b = 0.            *");
            Console.WriteLine("*   4. Exit                                              *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine();
            Console.Write("Input the number of operation you need: ");

            string choice = ValidateMenuInput();
            Console.WriteLine();

            switch (choice)
            {
                case "1": ReverseDigits(); break;
                case "2": CalculateAverage(); break;
                case "3": SolveEquation(); break;
                case "4": return;
            }
        }
    }

    static string ValidateMenuInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if ((input != "1") && (input != "2") && (input != "3") && (input != "4"))
            {
                Console.Write("Not valid input! Try again: ");
            }
            else
            {
                return input;
            }
        }
    }

    static void ReverseDigits()
    {
        Console.Write("Enter a non-negative decimal number: ");
        decimal number = ValidateReverseDigitsInput();
        string strNumber = number.ToString();
        char[] arr = strNumber.ToCharArray();
        Array.Reverse(arr);
        string reversedNumber = new string(arr);
        Console.WriteLine("The riversed number is {0}", reversedNumber);
    }

    static decimal ValidateReverseDigitsInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            decimal number;
            if (decimal.TryParse(input, out number))
            {
                if (number >= 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Not valid input! Try again: ");
                }
            }
            else
            {
                Console.Write("Not valid input! Try again: ");
            }
        }
    }

    static void CalculateAverage()
    {
        Console.Write("Enter the size of sequence, size > 0 : ");
        int size = ValidateCalculateAverageInput();
        int[] sequence = new int[size];
        decimal sum = 0;
        for (int i = 0; i < size; i++)
        {
            Console.Write( "Ënter element {0} : ", i+1);
            sequence[i] = int.Parse(Console.ReadLine());
            sum += sequence[i];
        }
        decimal average = sum / size;
        Console.WriteLine("The average of sequence is: {0}", average);
    }

    static int ValidateCalculateAverageInput()
    {
        while (true)
        {
            int size;
            string input = Console.ReadLine();
            if (int.TryParse(input, out size))
            {
                if (size > 0)
                {
                    return size;
                }
                else
                {
                    Console.Write("Not valid input! Try again: ");
                }
            }
            else
            {
                Console.Write("Not valid input! Try again: ");
            }
        }
    }

    static void SolveEquation()
    {
        Console.Write("Enter non zero coefficient \"a\" : ");
        decimal a = ValidateSolveEquationInput();
        Console.WriteLine();
        Console.Write("Enter coefficient \"b\" : ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        decimal x = -b / a;
        Console.WriteLine("x = {0}", x);

    }

    static decimal ValidateSolveEquationInput()
    {
        while (true)
        {
            decimal coefficient;
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out coefficient))
            {
                if (coefficient != 0)
                {
                    return coefficient;
                }
                else
                {
                    Console.Write("Not valid input! Try again: ");
                }
            }
            else
            {
                Console.Write("Not valid input! Try again: ");
            }
        }
    }
}

