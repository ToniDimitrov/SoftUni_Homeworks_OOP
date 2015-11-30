using System;

namespace Problem2_Bank_Of_Kurtovo_Konare
{
    internal class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(decimal balance, decimal interestRate, CustomerType customerType)
            : base(balance, interestRate, customerType)
        {
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw <= 0)
            {
                throw new ArgumentOutOfRangeException("The withdrawn amount must be positive");
            }
            this.Balance -= amountToWithdraw;
            Console.WriteLine("Withdraw Successful!");
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return this.Balance;
            }
            return this.Balance*(1 + (this.InterestRate*months));
        }
    }
}