/*  * Write a program that calculates for given N how many 
    trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Hint: The trailing zeros in N! are equal to the number 
    of its prime divisors of value 5.    */

using System;
class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter positive integer number N : ");
        int number = int.Parse(Console.ReadLine());

        //Finding how many prime divisors of value 5 has number N!
        int counter = 0;
        int reminder = 0;
        int newNumber;
        for (int i = 1; i <= number; i++)
        {
            newNumber = i;
            reminder = i % 5;
            while (reminder == 0)
            {
                newNumber = newNumber / 5;
                reminder = newNumber % 5;
                counter += 1;
            }
        }
        Console.WriteLine("The number of trailing zeroes in N! is {0}", counter);
    }
}

