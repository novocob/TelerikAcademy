/* 03. Write a program to convert decimal numbers 
 *     to their hexadecimal representation.*/

using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter integer number : ");
        int decimalNumber = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        int currentNumber = decimalNumber;
        while (currentNumber > 0)
        {
            sb.Append(FindLastHexadecimalDigit(currentNumber)); //here the next hexadecimal digit is inserted in the StringBuilder
            currentNumber /= 16;
        }
        Console.Write("Hexadecimal representation is : ");

        for (int i = sb.Length - 1; i >= 0; i--) //here the StringBuilder is printed backwards
        {
            Console.Write(sb[i]);
        }
        Console.WriteLine();

    }

    //this method finds the last hexadecimal digit of a decimal number
    static char FindLastHexadecimalDigit(int currentNumber)
    {
        int HexadecDigit = currentNumber % 16;
        if (HexadecDigit > 9)
        {
            char HexadecimalDigit = (char)(HexadecDigit + 55);
            return HexadecimalDigit;
        }
        else
        {
            char HexadecimalDigit = (char)(HexadecDigit + 48);
            return HexadecimalDigit;
        }
    }
}

