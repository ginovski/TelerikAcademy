using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    internal class Product
    {
        public Product(string name, decimal price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public override bool Equals(object obj)
        {
            Product obj2 = obj as Product;
            if (obj2 != null)
            {
                return this.Name.Equals(obj2.Name);
            }

            return false;
        }

        public override int GetHashCode()
        {
            int result = 13;

            result = 37 * result + this.Name.GetHashCode();

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1:G29})", this.Name, this.Price);
        }
    }

    internal class Range
    {
        public Range(decimal from, decimal to)
        {
            this.From = from;
            this.To = to;
        }

        public decimal From { get; set; }

        public decimal To { get; set; }

        public override bool Equals(object obj)
        {
            Range obj2 = obj as Range;

            if (obj2 == null)
            {
                return false;
            }

            return this.From == obj2.From && this.To == obj2.To;
        }

        public override int GetHashCode()
        {
            return this.From.GetHashCode() + this.To.GetHashCode() * 37;
        }
    }

    internal class Program
    {
        private static HashSet<Product> productsSet = new HashSet<Product>();
        private static Dictionary<string, List<Product>> typesOfProducts = new Dictionary<string, List<Product>>();

        private static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var commandParams = commandLine.Split(' ');
                string commandName = commandParams[0];

                switch (commandName)
                {
                    case "add":
                        ProcessAddCommand(commandParams);
                        break;

                    case "filter":
                        ProcessFilterCommand(commandParams);
                        break;
                }

                commandLine = Console.ReadLine();
            }
        }

        private static void ProcessFilterCommand(string[] commandParams)
        {
            string filterType = commandParams[2];

            if (filterType == "type")
            {
                string type = commandParams[3];
                if (typesOfProducts.ContainsKey(type))
                {
                    var result = typesOfProducts[type].OrderBy(p => p.Price).ThenBy(p => p.Name).ThenBy(p => p.Type).Take(10);
                    Console.WriteLine("Ok: {0}", string.Join(", ", result));
                }
                else
                {
                    Console.WriteLine("Error: Type {0} does not exists", type);
                }
            }
            else
            {
                decimal from = 0;
                decimal to = 0;
                if (commandParams.Length == 7)
                {
                    from = decimal.Parse(commandParams[4]);
                    to = decimal.Parse(commandParams[6]);
                }
                else
                {
                    if (commandParams[3] == "from")
                    {
                        from = decimal.Parse(commandParams[4]);
                        to = decimal.MaxValue;
                    }
                    else
                    {
                        from = decimal.MinValue;
                        to = decimal.Parse(commandParams[4]);
                    }
                }

                var result = productsSet
                    .Where(p => p.Price >= from && p.Price <= to)
                    .OrderBy(p => p.Price)
                    .ThenBy(p => p.Name)
                    .ThenBy(p => p.Type)
                    .Take(10);

                Console.WriteLine("Ok: {0}", string.Join(", ", result));
            }
        }

        private static void ProcessAddCommand(string[] commandParams)
        {
            string productName = commandParams[1];
            decimal productPrice = decimal.Parse(commandParams[2]);
            string productType = commandParams[3];

            var product = new Product(productName, productPrice, productType);

            if (productsSet.Contains(product))
            {
                Console.WriteLine("Error: Product {0} already exists", productName);
            }
            else
            {
                if (!typesOfProducts.ContainsKey(productType))
                {
                    typesOfProducts[productType] = new List<Product>();
                }

                productsSet.Add(product);
                typesOfProducts[productType].Add(product);
                Console.WriteLine("Ok: Product {0} added successfully", productName);
            }
        }
    }
}