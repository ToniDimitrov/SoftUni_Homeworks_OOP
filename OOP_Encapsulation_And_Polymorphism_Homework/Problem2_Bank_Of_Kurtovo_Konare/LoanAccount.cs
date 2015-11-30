namespace Problem2_Bank_Of_Kurtovo_Konare
{
    internal class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal interestRate, CustomerType customerType)
            : base(balance, interestRate, customerType)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if ((months <= 3 && this.CustomerType == CustomerType.Individual) ||
                (months <= 2 && this.CustomerType == CustomerType.Company))
            {
                return this.Balance;
            }

            return this.Balance*(1 + (this.InterestRate*months));
        }
    }
}