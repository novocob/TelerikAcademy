using System;

namespace _02.Bank
{
    public class LoanAcount : Acount, IDepositable
    {
        public LoanAcount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("The money must be a positive number!");
            }
            else
            {
                this.Balance += sum;
            }
        }

        public override decimal CalculateIntersestAmount(uint numberOfMonths)
        {
            decimal interestAmount = 0;
            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    interestAmount = (numberOfMonths - 3m) * this.InterestRate;
                    if (interestAmount < 0)
                    {
                        interestAmount = 0;
                    };
                    break;

                case "CompanyCustomer":
                    interestAmount = (numberOfMonths - 2m) * this.InterestRate;
                    if (interestAmount < 0)
                    {
                        interestAmount = 0;
                    };
                    break;

                default: throw new ArgumentException("Invalid type of customer!");
            }

            return interestAmount;
        }
    }
}
