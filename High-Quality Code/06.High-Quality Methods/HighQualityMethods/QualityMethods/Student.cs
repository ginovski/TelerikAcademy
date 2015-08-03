namespace QualityMethods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, DateTime dateOfBirth, string additionalInformation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.AdditionalInformation = additionalInformation;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value, "First name");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.ValidateName(value, "Last name");

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string AdditionalInformation { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = otherStudent.DateOfBirth;

            return firstDate > secondDate;
        }

        private void ValidateName(string value, string field)
        {
            if (value == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null", field));
            }

            if (value.Length < 3)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} cannot contain less than 3 symbols", field));
            }
        }
    }
}
