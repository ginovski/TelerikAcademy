namespace StudentsSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using Data;
    using System.Data.Entity;
    using Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            var db = new StudentSystemDbContext();

            var students = db.Students.Select(st => new
            {
                Name = st.Name,
                StudentNumber = st.StudentNumber
            })
            .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}