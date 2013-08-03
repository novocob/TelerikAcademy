/*  A marketing firm wants to keep record of its employees.
    Each record would have the following characteristics – first name, 
    family name, age, gender (m or f), ID number, unique employee number 
    (27 560 000 to 27 569 999). Declare the variables needed to keep the 
    information for a single employee using appropriate data types and descriptive names.   */


using System;
class MarketingFirmRecord
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string familyName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int idNumber = int.Parse(Console.ReadLine());
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Family name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Employee number: {0}", employeeNumber);
    }
}

