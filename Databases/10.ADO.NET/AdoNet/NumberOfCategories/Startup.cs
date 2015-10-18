//01.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
namespace NumberOfCategories
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        private static void Main()
        {
            SqlConnection db = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=true");
            db.Open();

            using (db)
            {
                var categoriesCountCommand = new SqlCommand("SELECT COUNT(*) AS CategoriesCount FROM Categories", db);
                var categoriesCount = categoriesCountCommand.ExecuteScalar();

                Console.WriteLine(categoriesCount);
            }
        }
    }
}