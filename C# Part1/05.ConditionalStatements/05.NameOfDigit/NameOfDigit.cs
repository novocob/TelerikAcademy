/*  Write program that asks for a digit and depending 
 * on the input shows the name of that digit 
 * (in English) using a switch statement.   */

using System;
class NameOfDigit
{
    static void Main()
    {
        bool check = true;
        while(check)
        {
            Console.Write("Enter a digit : ");
            string userInput = Console.ReadLine();
            int digit;
            bool result = int.TryParse(userInput, out digit);

            if ((digit < 0) || (digit > 9))
            {
                Console.WriteLine("This is not a digit! Try again!");
                continue;
            }
            else if ((digit == 0) && (userInput != "0"))
            {
                Console.WriteLine("This is not a digit! Try again!");
                continue;
            }
            else
            {
                check = false;
                switch (digit)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
        }
    }
}

