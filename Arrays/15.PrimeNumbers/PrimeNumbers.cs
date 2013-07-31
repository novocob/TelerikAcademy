/* 15. Write a program that finds all prime numbers 
 * in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;
class PrimeNumbers
{
    static void Main()
    {
        bool[] nums = new bool[10000001];   
        //using Eratosthenes algorithm the code finds all numbers "p"
        // that are not prime and turns the value nums[p]=false to nums[p]=true
        for (int p = 2; p < Math.Sqrt(10000000); p++)
        {
            if (nums[p]==true)  
            {
                continue;   //if the number p is already marked continue to next number
            }
            for (int i = 2; i <= 10000000 / p; i++)
            {
                nums[i * p] = true;   //mark numbers p,2p,3p.... 
            }
        }

        // print prime numbers
        for (int p = 2; p <= 10000000; p++)
        {
            if (nums[p] == false)
            {
                Console.WriteLine(p);
            }
            
        }
    }
}

