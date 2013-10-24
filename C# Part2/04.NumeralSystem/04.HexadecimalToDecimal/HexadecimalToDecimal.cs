/* 04. Write a program to convert hexadecimal 
 *     numbers to their decimal representation.*/

using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter Hexadecimal number : ");
        string hexadecNumber = Console.ReadLine();

        int decimalNumber = 0;
        int index = 0;
        while (index < hexadecNumber.Length)
        {
            int powered = 1;    //int "powered" gets this values :16^0, 16^1, 16^2, 16^3...
            for (int i = 0; i < hexadecNumber.Length - index - 1; i++)
            {
                powered *= 16;  // here is calculated the value of "powered", depending on "index" value
            }
            if (hexadecNumber[index] - 48 < 10) //if the current hexadecimal digit is in range [0..9]
            {
                decimalNumber = decimalNumber + (hexadecNumber[index] - 48) * powered;
                index++;
            }
            else //else the current hexadecimal digit is in range [A..F]
            {
                decimalNumber = decimalNumber + (hexadecNumber[index] - 55) * powered;
                index++;
            }
        }
        Console.WriteLine("Decimal representation is : {0}", decimalNumber);
    }
}