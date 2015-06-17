// Problem 12. Extract students by phone

// Extract all students with phones in Sofia.
// Use LINQ.

namespace ExtractStudentsByPhone
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


            var studentsWithPhoneInSofia = from st in students
                                         where st.Tel.IndexOf("02/") != -1
                                         select st;

            foreach (var student in studentsWithPhoneInSofia)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Tel);
            }
        }
    }
}
