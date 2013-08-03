/*  Write a program that, depending on the user's choice inputs int, 
 * double or string variable. If the variable is integer or double, 
 * increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. 
 * Use switch statement.    */

using System;
class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("What type of variable do you want to input?");
        Console.WriteLine("For \"int\" enter 1");
        Console.WriteLine("For \"double\" enter 2");
        Console.WriteLine("For \"string\" enter 3");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("Enter an integer number : ");
                int number = int.Parse(Console.ReadLine());
                number = number + 1;
                Console.WriteLine(number);
                break;
            case 2:
                Console.WriteLine("Enter a real number : ");
                double realNumber = double.Parse(Console.ReadLine());
                realNumber = realNumber + 1;
                Console.WriteLine(realNumber);
                break;
            case 3:
                Console.WriteLine("Enter a string : ");
                string userString = Console.ReadLine();
                userString = userString + "*";
                Console.WriteLine(userString);
                break;
            default:
                Console.WriteLine("Invalid choice !");
                break;
        }
    }
}

