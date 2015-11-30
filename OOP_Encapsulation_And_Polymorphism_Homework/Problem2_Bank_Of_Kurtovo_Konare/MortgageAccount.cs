namespace Problem2_Bank_Of_Kurtovo_Konare
{
    internal class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal interestRate, CustomerType customerType)
            : base(balance, interestRate, customerType)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 12 && this.CustomerType == CustomerType.Company)
            {
                return this.Balance*(1 + ((this.InterestRate/2.00m)*months));
            }
            if (months <= 6 && this.CustomerType == CustomerType.Individual)
            {
                return this.Balance;
            }
            return this.Balance*(1 + (this.InterestRate*months));
        }
    }
}