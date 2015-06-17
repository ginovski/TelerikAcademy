namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Price = milliliters * this.Price;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                this.usage = value;
            }
        }

        public override string Print()
        {
            var shampooBuilder = new StringBuilder(base.Print());

            shampooBuilder.AppendFormat("  * Quantity: {0} ml\n", this.Milliliters);
            shampooBuilder.AppendFormat("  * Usage: {0}", this.Usage);

            return shampooBuilder.ToString();
        }
    }
}
