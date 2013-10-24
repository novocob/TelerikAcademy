/* 01. Write a program that reads an integer number and 
 *     calculates and prints its square root. If the number 
 *     is invalid or negative, print "Invalid number". 
 *     In all cases finally print "Good bye". Use try-catch-finally. */

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter non negative integer number : ");
            uint number = uint.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

