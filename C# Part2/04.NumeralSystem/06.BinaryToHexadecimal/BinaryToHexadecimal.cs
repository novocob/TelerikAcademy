/* 06. Write a program to convert binary numbers 
 *     to hexadecimal numbers (directly).*/

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number : ");
        string binaryNumber = Console.ReadLine();
        StringBuilder HexadecimalNumber = new StringBuilder();

        /* if the number of binary digits is not divisible by 4
           the code inserts zeroes at the beginning of the binary number */
        switch (binaryNumber.Length % 4)
        {
            case 1: binaryNumber = "000" + binaryNumber; break;
            case 2: binaryNumber = "00" + binaryNumber; break;
            case 3: binaryNumber = "0" + binaryNumber; break;
            default: break;
        }

        /* now substract groups of four binary digits, find the equivalent
         * hexadecimal digit and append it in StringBuilder */
        for (int i = 0; i < binaryNumber.Length; i = i + 4)
        {
            string fourBinaryDigits = binaryNumber.Substring(i, 4);
            switch (fourBinaryDigits)
            {
                case "0000": HexadecimalNumber.Append("0"); break;
                case "0001": HexadecimalNumber.Append("1"); break;
                case "0010": HexadecimalNumber.Append("2"); break;
                case "0011": HexadecimalNumber.Append("3"); break;
                case "0100": HexadecimalNumber.Append("4"); break;
                case "0101": HexadecimalNumber.Append("5"); break;
                case "0110": HexadecimalNumber.Append("6"); break;
                case "0111": HexadecimalNumber.Append("7"); break;
                case "1000": HexadecimalNumber.Append("8"); break;
                case "1001": HexadecimalNumber.Append("9"); break;
                case "1010": HexadecimalNumber.Append("A"); break;
                case "1011": HexadecimalNumber.Append("B"); break;
                case "1100": HexadecimalNumber.Append("C"); break;
                case "1101": HexadecimalNumber.Append("D"); break;
                case "1110": HexadecimalNumber.Append("E"); break;
                case "1111": HexadecimalNumber.Append("F"); break;
            }
        }
        Console.WriteLine("Hexadecimal representation is : {0}", HexadecimalNumber);
    }
}

