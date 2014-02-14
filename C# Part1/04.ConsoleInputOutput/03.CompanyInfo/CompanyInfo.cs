/* A company has name, address, phone number, fax number,
 * web site and manager. The manager has first name, last name,
 * age and a phone number. Write a program that reads the information
 * about a company and its manager and prints them on the console.  */


using System;
class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company details");
        Console.Write("Name : ");
        string nameCompany = Console.ReadLine();
        Console.Write("Address : ");
        string address = Console.ReadLine();
        Console.Write("Phone number : ");
        string phoneNumberCompany = Console.ReadLine();
        Console.Write("Fax number : ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site : ");
        string webSite = Console.ReadLine();


        Console.WriteLine("Enter manager details");
        Console.Write("First name : ");
        string firstNameManager = Console.ReadLine();
        Console.Write("Last name : ");
        string lastNameManager = Console.ReadLine();
        Console.Write("Age : ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Phone number : ");
        string phoneNumberManager = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Company details :");
        Console.WriteLine(" Name : {0} \n Address : {1} \n Phone number : {2} \n Fax number : {3} \n Web site : {4}", 
                            nameCompany, address, phoneNumberCompany, faxNumber, webSite);
        Console.WriteLine();
        Console.WriteLine("Manager details :");
        Console.WriteLine(" First name : {0} \n Last name : {1} \n Age : {2} \n Phone number : {3}",
                            firstNameManager, lastNameManager, age, phoneNumberManager);
    }
}
