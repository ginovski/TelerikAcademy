namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const int ProductNameMaxLength = 10;
        private const int ProductNameMinLength = 3;
        private const int ProductBrandMaxLength = 10;
        private const int ProductBrandMinLength = 2;

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, ProductNameMaxLength, ProductNameMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", ProductNameMinLength, ProductNameMaxLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value, ProductBrandMaxLength, ProductBrandMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", ProductBrandMinLength, ProductBrandMaxLength));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price cannot be less than zero.");
                }

                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public virtual string Print()
        {
            var productInfoBuilder = new StringBuilder();

            productInfoBuilder.AppendFormat("- {0} - {1}:\n", this.Brand, this.Name);
            productInfoBuilder.AppendFormat("  * Price: ${0}\n", this.Price);
            productInfoBuilder.AppendFormat("  * For gender: {0}\n", this.Gender);

            return productInfoBuilder.ToString();
        }
    }
}
