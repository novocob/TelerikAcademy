/* Write a method that reverses the digits
 * of given decimal number. Example: 256  652 */

using System;
class ReversesDigits
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        string strNumber = (Math.Abs(number)).ToString();

        string riversedStrNumber = RiverseDigits(strNumber);

        if (number >= 0)
        {
            Console.WriteLine(riversedStrNumber);
        }
        else
        {
            Console.WriteLine("-"+ riversedStrNumber);
        }
        
    }

    static string RiverseDigits(string strNumber)
    {
        char[] arr = strNumber.ToCharArray();
        Array.Reverse(arr);
        string reversedNumber = new string(arr);
        return reversedNumber;
    }
}

