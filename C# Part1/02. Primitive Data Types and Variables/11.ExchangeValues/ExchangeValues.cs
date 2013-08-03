/*  lare  two integer variables and assign them with 5 and 10 
    and after that exchange their values.   */


using System;
class ExchangeValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
    }
}

