/*  We are given 5 integer numbers. Write a program that 
 * checks if the sum of some subset of them is 0. 
 * Example: 3, -2, 1, 1, 8  1+1-2=0.   */

using System;
class SubsetSum
{
    static void Main()
    {
        int[] numbers = new int[5];
        int counter = 0;
        Console.WriteLine("Enter five integer numbers");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("number {0} :",(i+1));
            numbers[i]=int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (numbers[i]==0)
            {
                Console.WriteLine("[{0}]", numbers[i]);
                counter += 1;
            }
            for (int j = i + 1; j < 5; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine("[{0}, {1}]", numbers[i], numbers[j]);
                    counter += 1;
                }
                for (int k = j + 1; k < 5; k++)
                {
                    if (numbers[i] + numbers[j] + numbers[k] == 0)
                    {
                        Console.WriteLine("[{0}, {1}, {2}]", numbers[i], numbers[j], numbers[k]);
                        counter += 1;
                    }
                    for (int l = k + 1; l < 5; l++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                        {
                            Console.WriteLine("[{0}, {1}, {2}, {3}]", numbers[i], numbers[j], numbers[k], numbers[l]);
                            counter += 1;
                        }
                    }
                }
            }

        }
        
        Console.WriteLine("The number of subsets with sum = 0 is : {0}", counter);  
    }
}

