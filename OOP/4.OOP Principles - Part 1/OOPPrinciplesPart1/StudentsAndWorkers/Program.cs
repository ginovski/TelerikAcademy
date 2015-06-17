// Problem 2. Students and workers

// Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshov", 5),
                new Student("Stamat", "Peshov", 3),
                new Student("Ilarion", "Mitkov", 6),
                new Student("Gosho", "Marinov", 2),
                new Student("Mitko", "Dimitrov", 3),
                new Student("Atanas", "Borisov", 4),
                new Student("Petko", "Voivoda", 2),
                new Student("Qne", "Ignatov", 2),
                new Student("Stamat", "Dimitrov", 6),
                new Student("Ana", "Peeva", 5),
            };

            var studentsByGrade = students.OrderBy(st => st.Grade);

            Console.WriteLine("Students \tGrade");
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Grade);
            }

            var workers = new List<Worker>()
            {
                new Worker("Pesho", "Peshov", 500, 8),
                new Worker("Stamat", "Peshov", 250, 5),
                new Worker("Ilarion", "Mitkov", 120, 12),
                new Worker("Gosho", "Marinov", 230, 6),
                new Worker("Mitko", "Dimitrov", 950, 9),
                new Worker("Atanas", "Borisov", 1000, 12),
                new Worker("Petko", "Voivoda", 500, 24),
                new Worker("Qne", "Ignatov", 200, 4),
                new Worker("Stamat", "Dimitrov", 600, 10),
                new Worker("Ana", "Peeva", 350, 12),
            };

            var workersByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine("\nWorkers \tMoney per hour");
            foreach (var worker in workersByMoneyPerHour)
            {
                Console.WriteLine("{0} {1} - {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            var people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedPeople = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            Console.WriteLine("\nAll people");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}
