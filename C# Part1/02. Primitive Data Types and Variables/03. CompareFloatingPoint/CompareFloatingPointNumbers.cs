/*  Write a program that safely compares floating-point numbers 
    with precision of 0.000001. Examples:
    (5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true.  */


using System;
class CompareFloatingPointNumbers
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool compare = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        Console.WriteLine(compare ? "The numbers are equal." : "The numbers are not equal.");
    }
}
