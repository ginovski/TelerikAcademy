// Problem 9. Student groups
// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
// Create a List<Student> with sample students. Select only the students that are from group number 2.
// Use LINQ query. Order the students by FirstName.

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", "012006", "088123412", "pesho@abv.bg",2, new List<int>() { 2, 3, 4, 5, 5, 6, 6, 2 }));
            students.Add(new Student("Gosho", "Peshev", "022008", "088125412", "gosho@gmail.com",3, new List<int>() { 3, 4, 4, 5, 5, 2 }));
            students.Add(new Student("Stamat", "Todorov", "032006", "088121212", "stamat@yahoo.com",4, new List<int>() { 2, 2, 3, 5 }));
            students.Add(new Student("Asparuh", "Dimitrov", "042007", "088123442", "asparuh@abv.bg",2, new List<int>() { 2, 2, 4, 5, 5, 6, 6 }));


            var studentsFromGroupTwo = from st in students
                                       where st.GroupNumber == 2
                                       orderby st.FirstName
                                       select st;

            foreach (var student in studentsFromGroupTwo)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
        }
    }
}
