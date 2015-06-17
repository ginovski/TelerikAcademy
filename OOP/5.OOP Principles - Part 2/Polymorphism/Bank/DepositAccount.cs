namespace Bank
{
    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        public DepositAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public double WithDraw(double money)
        {
            this.Balance -= money;
            return money;
        }

        public override double InterestAmount(int months)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.InterestAmount(months);
        }
    }
}
