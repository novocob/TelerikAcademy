/* 01. Write an expression that checks if given integer is odd or even. */


using System;
class CheckOddOrEven
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("The number {0} is even.", num);
        }
        else
        {
            Console.WriteLine("The number {0} is odd.", num);
        }
    }
}

