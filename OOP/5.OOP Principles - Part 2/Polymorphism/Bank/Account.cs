namespace Bank
{
    public abstract class Account : IDepositable
    {
        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public double Balance { get; protected set; }

        public double InterestRate { get; private set; }

        public virtual double InterestAmount(int months)
        {
            return this.InterestRate * months;
        }

        public void Deposit(double money)
        {
            this.Balance += money;
        }
    }
}
