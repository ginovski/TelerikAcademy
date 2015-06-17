namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IEnumerable<string> ingredients)
            : base(name, brand, price, gender)
        {
            Validator.CheckIfNull(ingredients, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Ingredients"));
            this.CheckValidityOfEachIngredient(ingredients);
            this.Ingredients = string.Join(", ", ingredients);
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Toothpaste ingredients"));

                this.ingredients = value;
            }
        }

        private void CheckValidityOfEachIngredient(IEnumerable<string> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient, 12, 4,
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));
            }
        }

        public override string Print()
        {
            var toothPasteBuilder = new StringBuilder(base.Print());

            toothPasteBuilder.AppendFormat("  * Ingredients: {0}", this.Ingredients);

            return toothPasteBuilder.ToString();
        }
    }
}
