/* 02. Write a program to convert binary 
 *     numbers to their decimal representation.*/

using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number : ");
        string binaryNumber = Console.ReadLine();

        int decimalNumber = 0;
        int index = 0;
        while (index < binaryNumber.Length)
        {
            int powered = 1;    //int "powered" gets this values :2^0, 2^1, 2^2, 2^3...
            for (int i = 0; i < binaryNumber.Length - index - 1; i++)
            {
                powered *= 2;   // here is calculated the value of "powered", depending on "index" value
            }
            decimalNumber = decimalNumber + (binaryNumber[index] - 48) * powered;
            index++;
        }
        Console.WriteLine("Decimal representation is : {0}", decimalNumber);
    }
}