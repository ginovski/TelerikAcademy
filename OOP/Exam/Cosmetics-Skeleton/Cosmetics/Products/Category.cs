namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private const int CategoryNameMaxLength = 15;
        private const int CategoryNameMinLength = 2;

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, CategoryNameMaxLength, CategoryNameMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", CategoryNameMinLength, CategoryNameMaxLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var categoryInfoBuilder = new StringBuilder();
            categoryInfoBuilder.AppendFormat("{0} category - {1} {2} in total", this.Name, this.products.Count, 
                this.products.Count == 1 ? "product" : "products");
            if (this.products.Count > 0)
            {
                categoryInfoBuilder.AppendLine();
                var sortedProducts = this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
                foreach (var product in sortedProducts)
                {
                    if (sortedProducts.Last() == product)
                    {
                        categoryInfoBuilder.Append(product.Print());
                    }
                    else
                    {
                        categoryInfoBuilder.AppendLine(product.Print());
                    }
                }
            }

            return categoryInfoBuilder.ToString();
        }
    }
}
