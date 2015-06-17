namespace Bank
{
    public class LoanAccount : Account, IDepositable
    {
        private const int MonthsWithoutRateForInvidualCustomers = 3;
        private const int MonthsWithoutRateForCompanyCustomers = 2;

        public LoanAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override double InterestAmount(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months <= MonthsWithoutRateForInvidualCustomers)
                {
                    return 0;
                }

                return this.InterestRate * (months - MonthsWithoutRateForInvidualCustomers);
            }

            else
            {
                if (months <= MonthsWithoutRateForCompanyCustomers)
                {
                    return 0;
                }

                return this.InterestRate * (months - MonthsWithoutRateForCompanyCustomers);
            }
        }
    }
}
