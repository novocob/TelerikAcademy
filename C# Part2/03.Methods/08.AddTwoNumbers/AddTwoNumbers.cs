/* Write a method that adds two positive integer numbers 
 * represented as arrays of digits (each array element arr[i] 
 * contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits. */

using System;
using System.Numerics;

class AddTwoNumbers
{
    static void Main()
    {
        // I will initialize the elements of the two arrays automatically.
        Console.Write("Enter how many digits has the first number ( in range 1 - 10000) : ");
        int firstNumberLength = int.Parse(Console.ReadLine());
        Console.Write("Enter how many digits has the second number ( in range 1 - 10000) : ");
        int secondNumberLength = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        //here the arrays are created and initialized
        char[] firstDigitsArray = GenerateArrayOfDigits(firstNumberLength, rnd); 
        char[] secondDigitsArray = GenerateArrayOfDigits(secondNumberLength, rnd);

        Console.WriteLine("This is the first array:");
        foreach (var digit in firstDigitsArray)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
        Console.WriteLine("This is the second array:");
        foreach (var digit in secondDigitsArray)
        {
            Console.Write(digit);
        }
        Console.WriteLine();

        //here is calculated the sum of the two numbers
        BigInteger addedNumbers = AddingTwoNumbers(firstDigitsArray, secondDigitsArray);
        Console.WriteLine("This is the sum of the two numbers:");
        Console.WriteLine(addedNumbers);
    }

    // this method generates random chars (digits from 0 to 9) and initiazlizes the elements of the array
    static char[] GenerateArrayOfDigits(int numberLength, Random rnd)
    {
        char[] arr = new char[numberLength];
        
        for (int i = 0; i < arr.Length -1 ; i++)
        {
            arr[i] = (char)rnd.Next(48, 58); //here is created random char with decimal code in range 48-57
        }
        arr[arr.Length - 1] = (char)rnd.Next(49, 58);   //the last element cannot be zero, because it is the first
                                                        // digit of the number
        return arr;
    }

    //this method reverses the arrays, converts them to string and then to BigInteger
    //and finally calculates and returns their sum
    static BigInteger AddingTwoNumbers(char[] firstDigitsArray, char[] secondDigitsArray)
    {
        Array.Reverse(firstDigitsArray);
        string firstNumberString = new string(firstDigitsArray);
        BigInteger firstNumber = BigInteger.Parse(firstNumberString);
        Console.WriteLine("This is the first number:");
        Console.WriteLine(firstNumber);
        
        Array.Reverse(secondDigitsArray);
        string secondNumberString = new string(secondDigitsArray);
        BigInteger secondNumber = BigInteger.Parse(secondNumberString);
        Console.WriteLine("This is the second number:");
        Console.WriteLine(secondNumber);
     
        return (firstNumber + secondNumber);
    }
}

