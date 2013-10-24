/* 07. Write a program to convert from any numeral system 
 * of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Text;

class AnyToAny
{
    static void Main()
    {
        Console.Write("Choose a base of numeral system in range [2..16] : ");
        int baseS = int.Parse(Console.ReadLine());
        Console.Write("Enter a number in the choosen numeral system : ");
        string inputNumber = Console.ReadLine();
        Console.Write("Choose a base to convert to in range [2..16] : ");
        int baseD = int.Parse(Console.ReadLine());

        int decimalNumber = FromBaseSToDecimal(inputNumber, baseS);
        string numberBaseD = FromDecimalToBaseD(decimalNumber, baseD);

        Console.WriteLine("The converted number is : {0}", numberBaseD);
    }

    private static string FromDecimalToBaseD(int decimalNumber, int baseD)
    {
        StringBuilder numberBaseD = new StringBuilder();
        int currentNumber = decimalNumber;
        while (currentNumber > 0)
        {
            numberBaseD.Append(FindLastBaseDDigit(currentNumber, baseD)); //here the next BaseD digit is inserted in the StringBuilder
            currentNumber /= baseD;
        }
        string finalNumberBaseD = numberBaseD.ToString();
        //the digits in finalNumberBaseD are backwards, so they have to be rearranged
        finalNumberBaseD = ReverseString(finalNumberBaseD); 
        return finalNumberBaseD;
        
    }

    private static int FromBaseSToDecimal(string baseSNumber, int baseS)
    {
        int decimalNumber = 0;
        int index = 0;
        while (index < baseSNumber.Length)
        {
            int powered = 1;    //int "powered" gets this values :baseS^0, baseS^1, baseS^2, baseS^3...
            for (int i = 0; i < baseSNumber.Length - index - 1; i++)
            {
                powered *= baseS;  // here is calculated the value of "powered", depending on "index" value
            }
            if (baseSNumber[index] - 48 < 10) //if the current baseS digit is in range [0..9]
            {
                decimalNumber = decimalNumber + (baseSNumber[index] - 48) * powered;
                index++;
            }
            else //else the current baseS digit is in range [A..F]
            {
                decimalNumber = decimalNumber + (baseSNumber[index] - 55) * powered;
                index++;
            }
        }
        return decimalNumber;
    }


    static char FindLastBaseDDigit(int currentNumber, int baseD)
    {
        int baseDDigit = currentNumber % baseD;
        if (baseDDigit > 9)
        {
            char nextBaseDDigit = (char)(baseDDigit + 55);
            return nextBaseDDigit;
        }
        else
        {
            char nextBaseDDigit = (char)(baseDDigit + 48);
            return nextBaseDDigit;
        }
    }

    static string ReverseString(string number)
    {
        StringBuilder numberBaseD = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            numberBaseD.Append(number[i]);
        }
        return numberBaseD.ToString();
    }
}

