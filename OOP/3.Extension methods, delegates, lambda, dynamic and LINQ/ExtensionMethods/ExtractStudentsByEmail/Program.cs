// Problem 11. Extract students by email
// Extract all students that have email in abv.bg.
// Use string methods and LINQ.

namespace ExtractStudentsByEmail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", "012006", "088123412", "pesho@abv.bg", 2, new List<int>() { 2, 3, 4, 5, 5, 6, 6, 2 }));
            students.Add(new Student("Gosho", "Peshev", "022008", "088125412", "gosho@gmail.com", 3, new List<int>() { 3, 4, 4, 5, 5, 2 }));
            students.Add(new Student("Stamat", "Todorov", "032006", "088121212", "stamat@yahoo.com", 4, new List<int>() { 2, 2, 3, 5 }));
            students.Add(new Student("Asparuh", "Dimitrov", "042007", "088123442", "asparuh@abv.bg", 2, new List<int>() { 2, 2, 4, 5, 5, 6, 6 }));


            var studentsWithEmailInAbv = from st in students
                                         where st.Email.IndexOf("abv.bg") != -1
                                         select st;

            foreach (var student in studentsWithEmailInAbv)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Email);
            }
        }
    }
}
