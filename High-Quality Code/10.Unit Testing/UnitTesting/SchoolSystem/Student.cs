namespace SchoolSystem
{
    using System;

    public class Student
    {
        private int id;
        private string name;

        public Student(string name)
        {
            this.Name = name;
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
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
                    throw new ArgumentException("Student name can not be null or empty");
                }

                this.name = value;
            }
        }
    }
}