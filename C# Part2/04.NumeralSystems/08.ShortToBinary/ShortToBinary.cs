/*Write a program that shows the binary representation of 
 * given 16-bit signed integer number (the C# type short). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Enter integer number in range [-32768..32767] : ");
        short inputNumber = short.Parse(Console.ReadLine());
        short decimalNumber = inputNumber;

        if (inputNumber < 0)
        {
           decimalNumber = (short)(- decimalNumber - 1); //for negative numbers I use this formula: -a = ~ (a-1)
        }
        StringBuilder binaryDigits = ConvertTo16BitBinary(decimalNumber);
        if (inputNumber < 0)
        {
            binaryDigits = InvertBits(binaryDigits); // here (a-1) is converted to ~(a-1)
        }
        Console.WriteLine("16 bit binary representation is : {0}", binaryDigits);
    }

    // in this method a decimal positive number is converted to 16bit binary
    static StringBuilder ConvertTo16BitBinary(short decimalNumber)
    {
        List<int> binaryReversedDigits = new List<int>(); //at the beginning here will be kept the binary digits (in reversed order)
        StringBuilder binaryDigits = new StringBuilder(); //
        while (decimalNumber > 0)
        {
            binaryReversedDigits.Add(decimalNumber % 2); //calculate and add in array the digits
            decimalNumber /= 2;
        }
        for (int i = 0; i < 16 - binaryReversedDigits.Count; i++)
        {
            binaryDigits.Append('0'); //first zeroes are added to fill all 16bits (if needed)
        }
        for (int i = binaryReversedDigits.Count - 1; i >= 0; i--)
        {
            binaryDigits.Append(binaryReversedDigits[i]); //the digits from array are appended here backwards
        }
        return binaryDigits;
    }

    //this method is used only when inputNumber is negative and the formula -a = ~ (a-1) must be used
    static StringBuilder InvertBits(StringBuilder binaryDigits)
    {
        for (int i = 0; i < binaryDigits.Length; i++)
        {
            if (binaryDigits[i] == '0')
            {
                binaryDigits[i] = '1';
            }
            else if (binaryDigits[i] == '1')
            {
                binaryDigits[i] = '0';
            }
        }
        return binaryDigits;
    }
}

