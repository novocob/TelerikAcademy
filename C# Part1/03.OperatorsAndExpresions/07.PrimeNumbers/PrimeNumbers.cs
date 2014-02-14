/*  Write an expression that checks if given positive 
    integer number n (n ≤ 100) is prime. E.g. 37 is prime.   */


using System;
class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Input number: ");
        int num = int.Parse(Console.ReadLine());
        int biggestDivNum = (int) Math.Sqrt(num);
        bool check = true;
        for (int i = 2; i <= biggestDivNum; i++)
        {
            if (num % i == 0)
            {
                check = false;
                break;
            }
        }
        Console.WriteLine(check ? num + " is prime." : num + " is not prime." );
    }
}

