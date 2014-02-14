/*  A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit 
 * card numbers associated with the account. Declare the variables needed to keep 
 * the information for a single bank account using 
 * the appropriate data types and descriptive names.    */
 

using System;
class BankAccount
{
    static void Main()
    {
        string firstName = "Petko";
        string middleName = "Petkov";
        string lastName = "Petkov";
        decimal balance = 543218.35m;
        string bankName = "Big Falit Bank";
        string iban = "BG19STSA76540000055454";
        string bic = "BUINFGSF";
        ulong creditCardNumber1 = 1111222233334444;
        ulong creditCardNumber2 = 2222333344445555;
        ulong creditCardNumber3 = 3333444455556666;

        Console.WriteLine("{0} {1} {2}",firstName, middleName, lastName);
        Console.WriteLine("Balance : {0} USD", balance);
        Console.WriteLine("Bank : {0}", bankName);
        Console.WriteLine("IBAN : {0}", iban);
        Console.WriteLine("BIC code : {0}", bic);
        Console.WriteLine("Credit Card Numbers : {0}, {1}, {2}", creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}

