﻿/*  Declare five variables choosing for each of them the most 
    appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
    to represent the following values: 52130, -115, 4825932, 97, -10000. */

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte forthVariable = 97;
        short fifthVariable = -10000;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", firstVariable,
        secondVariable, thirdVariable, forthVariable, fifthVariable);
    }
}

