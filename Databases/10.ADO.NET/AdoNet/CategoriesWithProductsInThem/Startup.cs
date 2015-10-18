//03.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
//Can you do this with a single SQL query (with table join)?
namespace CategoriesWithProductsInThem
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class Startup
    {
        private static void Main()
        {
            var db = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=true");
            db.Open();

            using (db)
            {
                var categoriesWithProductsCommand = new SqlCommand(@"SELECT p.ProductName, c.CategoryName FROM Products p
                                                                     INNER JOIN Categories c
                                                                     ON p.CategoryID = c.CategoryID", db);

                var categoriesWithProducts = new Dictionary<string, ICollection<string>>();
                var categoriesWithProductsReader = categoriesWithProductsCommand.ExecuteReader();
                using (categoriesWithProductsReader)
                {
                    string categoryName;
                    string productName;

                    while (categoriesWithProductsReader.Read())
                    {
                        categoryName = (string)categoriesWithProductsReader["CategoryName"];
                        productName = (string)categoriesWithProductsReader["ProductName"];

                        if (!categoriesWithProducts.ContainsKey(categoryName))
                        {
                            categoriesWithProducts.Add(categoryName, new List<string>());
                        }

                        categoriesWithProducts[categoryName].Add(productName);
                    }
                }

                foreach (var category in categoriesWithProducts)
                {
                    var categoryName = category.Key;
                    var products = category.Value;

                    Console.WriteLine(category.Key);
                    foreach (var product in products)
                    {
                        Console.WriteLine(product.PadLeft(product.Length + 4, ' '));
                    }

                    Console.WriteLine(string.Join("-", new string[15]));
                }
            }
        }
    }
}