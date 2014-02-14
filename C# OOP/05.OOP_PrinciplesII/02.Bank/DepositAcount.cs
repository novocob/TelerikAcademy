using System;

namespace _02.Bank
{
    public class DepositAcount : Acount, IDepositable, IWithDrawable
    {
        public DepositAcount(Customer customer, decimal balance, decimal interestRate)
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

        public void WithDraw(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("The money must be a positive number!");
            }
            else
            {
                this.Balance -= sum;
            }
        }

        public override decimal CalculateIntersestAmount(uint numberOfMonths)
        {
            decimal interestAmount = 0m;
            interestAmount = numberOfMonths * this.InterestRate;

            if((this.Balance > 0) && (this.Balance < 1000))
            {
                interestAmount = 0;
            }

            return interestAmount;
        }
    }
}
