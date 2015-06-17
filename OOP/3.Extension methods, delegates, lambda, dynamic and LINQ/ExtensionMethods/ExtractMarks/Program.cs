// Problem 15. Extract marks

// Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

namespace ExtractMarks
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


            var studentsEnrolledIn2006Marks = students.Where(st => st.FN[4] == '0' && st.FN[5] == '6').Select(st => new { Marks = st.Marks });

            foreach (var student in studentsEnrolledIn2006Marks)
            {
                Console.WriteLine("[{0}]",string.Join(", ", student.Marks));
            }
        }
    }
}
