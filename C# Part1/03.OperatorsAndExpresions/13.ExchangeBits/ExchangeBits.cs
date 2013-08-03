/*  Write a program that exchanges bits 3, 4 and 5 with 
    bits 24, 25 and 26 of given 32-bit unsigned integer.  */


using System;
class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Input number : ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Number {0} in binary system is : {1}.", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        byte bitPositionA = 3;
        byte bitPositionB = 24;
        byte bitA;  // bitA is the bit at position bitPositionA
        byte bitB;  // bitB is the bit at position bitPositionB
        uint mask;
        uint modifiedNumber = number;

        for (byte i = 1; i <= 3; i++, bitPositionA++, bitPositionB++)
        {
            bitA = (byte)((number >> bitPositionA) & 1);
            bitB = (byte)((number >> bitPositionB) & 1);
            if (bitA == bitB) continue;
            else
            {
                if (bitA == 0)
                {
                    // Change bitB at position bitPositionB
                    mask = (uint)(~(1 << bitPositionB));
                    modifiedNumber = modifiedNumber & mask;

                    // Change bitA at position bitPositionA
                    mask = (uint)(1 << bitPositionA);
                    modifiedNumber = modifiedNumber | mask;
                }
                else
                {
                    // Change bitB at position bitPositionB
                    mask = (uint)(1 << bitPositionB);
                    modifiedNumber = modifiedNumber | mask;
                  
                    // Change bitA at position bitPositionA
                    mask = (uint)(~(1 << bitPositionA));
                    modifiedNumber = modifiedNumber & mask;
                }
            }
        }
        Console.WriteLine("The modified number in binary system is : {0}", Convert.ToString(modifiedNumber, 2).PadLeft(32, '0'));
    }
}

