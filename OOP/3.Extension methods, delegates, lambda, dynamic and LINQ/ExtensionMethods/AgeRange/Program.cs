// Problem 4. Age range
// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Goshev", 16));
            students.Add(new Student("Asparuh", "Dimitrov", 25));
            students.Add(new Student("Ilarion", "Masev", 18));
            students.Add(new Student("Qne", "Petrov", 20));

            var studentsBetween18And24 = from st in students
                                         where st.Age >= 18 && st.Age <= 24
                                         select new { FirstName = st.FirstName, LastName = st.LastName };

            foreach (var student in studentsBetween18And24)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
