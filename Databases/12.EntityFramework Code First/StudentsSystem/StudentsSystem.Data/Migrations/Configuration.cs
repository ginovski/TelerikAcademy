namespace StudentsSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            var randomGenerator = RandomGenerator.Instance;
            if (context.Students.Any())
            {
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                var newCourse = new Course
                {
                    Name = randomGenerator.GetRandomString(5, 30),
                    Description = randomGenerator.GetRandomString(10, 100)
                };

                context.Courses.Add(newCourse);
            }

            context.SaveChanges();

            var courses = context.Courses.ToList();

            for (int i = 0; i < 30; i++)
            {
                var newStudent = new Student
                {
                    Name = randomGenerator.GetRandomString(3, 50),
                    StudentNumber = randomGenerator.GetRandomString(7, 7)
                };

                newStudent.Courses.Add(courses[randomGenerator.GetRandomNumber(0, courses.Count - 1)]);

                context.Students.Add(newStudent);
            };

            context.SaveChanges();
        }
    }
}