/*  Write a boolean expression that checks for given integer 
    if it can be divided (without remainder) by 7 and 5 in the same time. */


using System;
class DivisionBy7And5
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool check = ((num % 5 == 0) && (num % 7 == 0));
        if (check)
        {
            Console.WriteLine("The number {0} can be divided by 7 and 5 at the same time.", num);
        }
        else
        {
            Console.WriteLine("The number {0} can not be divided by 7 and 5 at the same time.", num);
        }
    }
}

