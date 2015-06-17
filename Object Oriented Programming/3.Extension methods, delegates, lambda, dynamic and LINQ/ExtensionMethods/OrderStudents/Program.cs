// Problem 5. Order students
// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
// Rewrite the same with LINQ.
namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Goshev"));
            students.Add(new Student("Asparuh", "Dimitrov"));
            students.Add(new Student("Ilarion", "Masev"));
            students.Add(new Student("Qne", "Petrov"));

            //With extension methods
            var sortedStudents = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            Console.WriteLine("With extension methods\n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();
            //With LINQ
            var sortedStudentsLinq = from st in students
                                     orderby st.FirstName descending, st.LastName descending
                                     select st;

            Console.WriteLine("With LINQ\n");
            foreach (var student in sortedStudentsLinq)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
