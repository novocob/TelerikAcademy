/*  Which of the following values can be assigned
    to a variable of type float and which to a variable of type 
    double: 34.567839023, 12.345, 8923.1234857, 3456.091?   */


using System;
class VariablesFloatAndDouble
{
    static void Main()
    {
        double firstVariable = 34.567839023;
        float secondVariavle = 12.345f;
        double thirdVariable = 8923.1234857;
        float fourthVariavle = 3456.091f;
        Console.WriteLine("Type float: {0}, {1}", secondVariavle, fourthVariavle);
        Console.WriteLine("Type double: {0}, {1}", firstVariable, thirdVariable);      
    }
}

