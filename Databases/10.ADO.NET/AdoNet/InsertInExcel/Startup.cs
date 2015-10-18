//07.Implement appending new rows to the Excel file.
namespace InsertInExcel
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
                var command = new OleDbCommand("INSERT INTO [Users$] (Name, Score) VALUES(@name, @score)", excelConnection);
                command.Parameters.Add(new OleDbParameter("@name", "Spasko"));
                command.Parameters.Add(new OleDbParameter("@score", 60));

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Rows affected: {0}", rowsAffected);
                }
            }
        }
    }
}