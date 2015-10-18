//04.Write a method that adds a new product in the products table in the Northwind database.
//Use a parameterized SQL command.
namespace AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        private static void Main()
        {
            var db = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=true");

            db.Open();

            using (db)
            {
                string productName = "Test Product";
                var insertProductCommand = new SqlCommand(@"INSERT INTO Products (ProductName)
                                                            VALUES (@productName)", db);
                insertProductCommand.Parameters.Add(new SqlParameter("@productName", productName));

                int rowsAffected = insertProductCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product added");
                }
            }
        }
    }
}