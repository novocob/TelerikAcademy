using System;

namespace _02.Bank
{
    class TestProgram
    {
        static void Main()
        {
            IndividualCustomer indCustomer = new IndividualCustomer("Iva Petrova", "0000001");
            CompanyCustomer comCustomer = new CompanyCustomer("Atia ltd", "0000002");
            MortgageAcount mortAcount = new MortgageAcount(indCustomer, 1000m, 1.5m);
            LoanAcount loanAcount = new LoanAcount(comCustomer, 5000m, 2m);
            DepositAcount depAcount = new DepositAcount(indCustomer, 2000m, 2);

            Console.WriteLine(mortAcount.Customer.Name + "  " + mortAcount.Customer.ID);
            Console.WriteLine("Interest amount: " + mortAcount.CalculateIntersestAmount(5));
            Console.WriteLine();
            Console.WriteLine(loanAcount.Customer.Name + "  " + loanAcount.Customer.ID);
            Console.WriteLine("Interest amount: " + loanAcount.CalculateIntersestAmount(10));
            Console.WriteLine();
            Console.WriteLine(depAcount.Customer.Name + "  " + depAcount.Customer.ID);
            Console.WriteLine("Interest amount: " + depAcount.CalculateIntersestAmount(7));
            Console.WriteLine("Current balance: " + depAcount.Balance);
            depAcount.Deposit(250.56m);
            Console.WriteLine("Current balance: " + depAcount.Balance);
            depAcount.WithDraw(250.56m);
            Console.WriteLine("Current balance: " + depAcount.Balance);
        }
    }
}
