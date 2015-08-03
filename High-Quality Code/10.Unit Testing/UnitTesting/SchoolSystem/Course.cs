namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxCourseCapacity = 30;

        private string name;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name can not be empty");
                }

                this.name = value;
            }
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
            if (this.students.Count == 30)
            {
                throw new InvalidOperationException("Course is full");
            }

            this.students.Add(student);
        }

        public Student RemoveStudent(Student student)
        {
            if (!this.students.Remove(student))
            {
                throw new InvalidOperationException("There is no such student in the course");
            }

            return student;
        }
    }
}