/*  ​Declare two string variables and assign them with “Hello” and “World”. 
    Declare an object variable and assign it with the concatenation of the 
    first two variables (mind adding an interval). Declare a third string variable and 
    initialize it with the value of the object variable (you should perform type casting). */


using System;
class StringHelloWorld
{
    static void Main(string[] args)
    {
        string firstVar = "Hello";
        string secondVar = "World";
        object firstObject = firstVar + " " + secondVar;
        string thirdVar = (string)firstObject;
        Console.WriteLine(thirdVar);
    }
}

