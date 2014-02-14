/*  Write a program to calculate the sum 
 * (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...    */


using System;
class SumAccuracy
{
    static void Main()
    {
        decimal sum = 1m;
        int sign = +1;

        for (int i = 2; i <= 1000; i++)
        {
            sum = sum + sign * (1m / i);
            sign = -sign;
        }
        sum = Math.Round(sum, 3);
        Console.WriteLine("Sum with accuracy 0.001 is : {0}", sum);
    }
}

