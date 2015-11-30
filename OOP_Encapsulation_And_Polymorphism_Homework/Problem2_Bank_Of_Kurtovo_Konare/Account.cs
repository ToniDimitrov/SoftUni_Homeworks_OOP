using System;

namespace Problem2_Bank_Of_Kurtovo_Konare
{
    internal abstract class Account : IInterestCalculatable, IDepositable
    {
        private decimal balance;
        private decimal interestRate;

        public Account(decimal balance, decimal interestRate, CustomerType customerType)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.CustomerType = customerType;
        }

        public CustomerType CustomerType { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance must be non-negative");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest must be non-negative");
                }
                this.interestRate = value;
            }
        }

        public void Deposit(decimal amountToDeposit)
        {
            this.Balance += amountToDeposit;
            Console.WriteLine("Deposit Successful!");
        }

        public abstract decimal CalculateInterest(int months);
    }
}