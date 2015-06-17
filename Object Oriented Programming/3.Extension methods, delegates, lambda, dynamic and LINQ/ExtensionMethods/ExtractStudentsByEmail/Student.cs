namespace ExtractStudentsByEmail
{
    using System.Collections.Generic;

    public class Student
    {
        private IList<int> marks;

        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, IList<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public int GroupNumber { get; set; }

        public IList<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
            set
            {
                this.marks = new List<int>(value);
            }
        }
    }
}
