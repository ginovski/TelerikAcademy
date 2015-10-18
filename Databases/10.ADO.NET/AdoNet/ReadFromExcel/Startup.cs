//06.Create an Excel file with 2 columns: name and score:
//Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
namespace ReadFromExcel
{
    using System;
    using System.Data.OleDb;

    public class Startup
    {
        private static void Main()
        {
            var excelConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../Scores.xls;Extended Properties='Excel 8.0;HDR=Yes'");

            excelConnection.Open();

            using (excelConnection)
            {
                var command = new OleDbCommand("SELECT Name, Score FROM [Users$]", excelConnection);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];

                        Console.WriteLine("{0} ---> {1}", name, score);
                    }
                }
            }
        }
    }
}