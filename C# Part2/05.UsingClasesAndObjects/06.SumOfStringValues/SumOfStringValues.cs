/* 06.You are given a sequence of positive integer values 
 *    written into a string, separated by spaces. 
 *    Write a function that reads these values from given 
 *    string and calculates their sum. 
 *    Example: string = "43 68 9 23 318"  result = 461  */

using System;

class SumOfStringValues
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer values, separated by spaces : ");
        string numberSequence = Console.ReadLine().Trim();
        
        char[] separators = new char[] {' '};
        string[] stringNumbers = numberSequence.Split(separators);
        int sum = 0;
        foreach (string number in stringNumbers)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine("The sum is : {0}", sum);
    }
}

