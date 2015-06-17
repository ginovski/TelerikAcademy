namespace SchoolClasses
{
    using System;

    public class Student : Person
    {
        private static int UniqueClassNumberGenerator = 1;

        public Student(string name) : base(name)
        {
            this.ClassNumber = UniqueClassNumberGenerator++;
        }

        public int ClassNumber { get; set; }
    }
}
