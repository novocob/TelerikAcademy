/*  Write an if statement that examines two integer 
 * variables and exchanges their values if 
 * the first one is greater than the second one.    */


using System;
class ChangeValues
{
    static void Main()
    {
        Console.Write("Enter variable A : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter variable B : ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
            Console.WriteLine("The new values are:");
            Console.WriteLine("A : {0}", firstNumber);
            Console.WriteLine("B : {0}", secondNumber);
        }
    }
}

