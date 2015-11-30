using System;
using System.Collections.Generic;

namespace Problem2_Bank_Of_Kurtovo_Konare
{
    internal class Problem2
    {
        private static void Main(string[] args)
        {
            var mortgage = new MortgageAccount(12000m, 0.05m, CustomerType.Individual);
            var deposit = new DepositAccount(1340m, 0.02m, CustomerType.Individual);
            var loan = new LoanAccount(10000m, 0.1m, CustomerType.Individual);
            var mortgage2 = new MortgageAccount(12000m, 0.05m, CustomerType.Company);
            var deposit2 = new DepositAccount(1340m, 0.02m, CustomerType.Company);
            var loan2 = new LoanAccount(10000m, 0.1m, CustomerType.Company);

            deposit.Withdraw(111);
            deposit2.Withdraw(222);

            var accounts = new List<Account>
            {
                mortgage,
                deposit,
                loan,
                mortgage2,
                deposit2,
                loan2
            };

            foreach (var account in accounts)
            {
                Console.WriteLine("Account type: {0}",account.GetType().Name);
                Console.WriteLine("Account balance after 12 months with {0:P} interest: {1:C}", account.InterestRate,
                    account.CalculateInterest(12));
                account.Deposit(100);
                Console.WriteLine("Account balance: {0:C}\n", account.Balance);
            }
        }
    }
}