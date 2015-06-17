namespace Bank
{
    using System;
    using System.Collections.Generic;

    public class TestBank
    {
        public static void Main()
        {
            var accounts = new List<Account>
            {
                new DepositAccount(new CompanyCustomer(), 1000.3, 4.5),
                new DepositAccount(new IndividualCustomer(), 250.3, 4.5),
                new LoanAccount(new CompanyCustomer(), 500, 6.5),
                new LoanAccount(new IndividualCustomer(), 300.3, 2.5),
                new MortgageAccount(new CompanyCustomer(), 400, 2.5),
                new MortgageAccount(new IndividualCustomer(), 150.6, 2.5)
            };

            foreach (var account in accounts)
            {
                Console.WriteLine(account.InterestAmount(6));
            }
        }
    }
}
