/*  Write a program that applies bonus scores to given scores 
 * in the range [1..9]. The program reads a digit as an input. 
 * If the digit is between 1 and 3, the program multiplies it by 10; 
 * if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, 
 * multiplies it by 1000. If it is zero or if the value is not a digit, 
 * the program must report an error.
   Use a switch statement and at the end print the calculated new value in the console. */

using System;
class BonusScores
{
    static void Main()
    {
        byte userChoice;
        int result = 0;

        while (true)
        {
            Console.Write("Enter a digit in the range [1..9] : ");
            bool check = byte.TryParse(Console.ReadLine(), out userChoice);
            if ((userChoice < 1) || (userChoice > 9))
            {
                Console.WriteLine("Invalid input! Try again!");
            }
            else
            {
                break;
            }
        }
        switch (userChoice)
        {
            case 1 :
            case 2 :
            case 3 :
                result = userChoice * 10;
                break;
            case 4 :
            case 5 :
            case 6 :
                result = userChoice * 100;
                break;
            case 7:
            case 8:
            case 9:
                result = userChoice * 1000;
                break;
        }
        Console.WriteLine("Result is : {0}", result);
    }
}

