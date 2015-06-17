// Problem 13. Extract students by marks
// Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
// Use LINQ.

namespace ExtractStudentsByMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", "012006", "02/123412", "pesho@abv.bg", 2, new List<int>() { 2, 3, 4, 5, 5, 6, 6, 2 }));
            students.Add(new Student("Gosho", "Peshev", "022008", "02/125412", "gosho@gmail.com", 3, new List<int>() { 3, 4, 4, 5, 5, 2 }));
            students.Add(new Student("Stamat", "Todorov", "032006", "12/121212", "stamat@yahoo.com", 4, new List<int>() { 2, 2, 3, 5 }));
            students.Add(new Student("Asparuh", "Dimitrov", "042007", "34/123442", "asparuh@abv.bg", 2, new List<int>() { 2, 2, 4, 5, 5, 6, 6 }));


            var studentsWithExcelentMark = from st in students
                                           where st.Marks.IndexOf(6) != -1
                                           select new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks };

            foreach (var student in studentsWithExcelentMark)
            {
                Console.WriteLine("{0} [{1}]", student.FullName, string.Join(", ", student.Marks));
            }
        }
    }
}
