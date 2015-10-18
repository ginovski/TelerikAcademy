//02.Write a program that retrieves the name and description of all categories in the Northwind DB.
namespace NameAndDescriptionOfCategories
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
                var categoriesCommand = new SqlCommand("SELECT CategoryName, Description FROM Categories", db);
                var categoriesReader = categoriesCommand.ExecuteReader();

                using (categoriesReader)
                {
                    while (categoriesReader.Read())
                    {
                        Console.WriteLine("Name: {0}", categoriesReader["CategoryName"]);
                        Console.WriteLine("Description: {0}", categoriesReader["Description"]);
                        Console.WriteLine(string.Join("-", new string[10]));
                    }
                }
            }
        }
    }
}