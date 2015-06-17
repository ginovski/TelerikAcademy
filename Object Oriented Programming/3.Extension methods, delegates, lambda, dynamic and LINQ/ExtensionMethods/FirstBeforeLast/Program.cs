// Problem 3. First before last
// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

namespace FirstBeforeLast
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

            var firstNameBeforeLast = from st in students
                                      where st.FirstName.CompareTo(st.LastName) == -1
                                      select st;

            foreach (var student in firstNameBeforeLast)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
