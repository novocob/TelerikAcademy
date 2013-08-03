/*  Write an expression that checks for given integer 
    if its third digit (right-to-left) is 7. E. g. 1732  true.  */

using System;
class IsThirdDigit7
{
    static void Main()
    {
        // First Variant - using numbers
        Console.Write("Input the number: ");
        int num = int.Parse(Console.ReadLine());
        int dividedNum = Math.Abs(num / 100);
        bool check = (dividedNum % 10 == 7);
        Console.WriteLine("{0} -> {1}", num, check);

        // Second Variant - using string and char
        Console.Write("Input the number: ");
        string numString = Console.ReadLine();
        int length = numString.Length;
        bool check2 = false;
        if (length >= 3)
        {
            char thirdDigit = numString[length - 3];
            check2 = (thirdDigit == '7');
        }
        Console.WriteLine("{0} -> {1}", numString, check2);
    }
}

