namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private const int MaxStudents = 99999;

        private int id;
        private IList<Student> students;

        public School()
        {
            this.students = new List<Student>();
            this.id = 10000;
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
            if (this.id > MaxStudents)
            {
                throw new ArgumentException("School is full");
            }

            student.ID = this.id++;

            this.students.Add(student);
        }
    }
}