namespace Bank
{
    public class MortgageAccount : Account, IDepositable
    {
        private const int MonthsWithoutRateForInvidualCustomers = 6;
        private const int MonthsWithHalfRateForCompanyCustomers = 12;

        public MortgageAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override double InterestAmount(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return this.InterestRate * (months - MonthsWithoutRateForInvidualCustomers);
            }
            else
            {
                return (this.InterestRate * (months - MonthsWithHalfRateForCompanyCustomers)) + ((this.InterestRate * 0.5) * MonthsWithHalfRateForCompanyCustomers);
            }
        }
    }
}
