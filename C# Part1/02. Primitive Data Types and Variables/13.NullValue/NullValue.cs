/*  ​Create a program that assigns null values to an integer 
    and to double variables. Try to print them on the console, try to add some 
    values or the null literal to them and see the result.  */
 

using System;
class NullValue
{
    static void Main(string[] args)
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine("intVar = " + intVar);
        Console.WriteLine("intVar has value: " + intVar.HasValue);
        Console.WriteLine("doubleVar = " + doubleVar);
        Console.WriteLine();
        
        intVar = intVar + 10;
        doubleVar = doubleVar + 20;
        Console.WriteLine("intVar = " + intVar);
        Console.WriteLine("intVar has value: " + intVar.HasValue);
        Console.WriteLine("doubleVar = " + doubleVar);
        Console.WriteLine();

        intVar = 10;
        doubleVar = 20;
        Console.WriteLine("intVar = " + intVar);
        Console.WriteLine("intVar has value: " + intVar.HasValue);
        Console.WriteLine("doubleVar = " + doubleVar);
        Console.WriteLine();

        intVar = 0;
        doubleVar = 0;
        Console.WriteLine("intVar = " + intVar);
        Console.WriteLine("intVar has value: " + intVar.HasValue);
        Console.WriteLine("doubleVar = " + doubleVar);
        Console.WriteLine();

        intVar = 0 + null;
        doubleVar = 0 + null;
        Console.WriteLine("intVar = " + intVar);
        Console.WriteLine("intVar has value: " + intVar.HasValue);
        Console.WriteLine("doubleVar = " + doubleVar);
        Console.WriteLine();
    }
}

