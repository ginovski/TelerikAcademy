namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
            for (int i = 0; i < students.Count; i++)
            {
                this.AddStudent(students[i]);
            }
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }
        
        public void AddStudent(string name)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentException("Student name cannot be null or empty");
            }

            this.Students.Add(name);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(this.GetType().Name + " { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
