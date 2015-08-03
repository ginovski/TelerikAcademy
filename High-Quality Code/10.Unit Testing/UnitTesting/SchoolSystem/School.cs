namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private static int id = 10000;

        private const int MaxStudents = 99999;

        private IList<Student> students;

        public School()
        {
            this.students = new List<Student>();
        }

        public IList<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (id > MaxStudents)
            {
                throw new ArgumentException("School is full");
            }

            student.ID = id++;

            this.students.Add(student);
        }
    }
}