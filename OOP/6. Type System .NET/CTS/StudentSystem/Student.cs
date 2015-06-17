namespace StudentSystem
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private static int ssnGenerator = 1;

        public Student(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssnGenerator++;
            this.Course = null;
            this.Specialty = null;
            this.Faculty = null;
            this.University = null;
        }

        public Student(string firstName, string middleName, string lastName, string address, string mobilePhone, string email)
            : this(firstName, middleName, lastName)
        {
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
        }

        public Student(string firstName, string middleName, string lastName, string address, string mobilePhone, string email,
                        int? course, SpecialtyEnum? specialty, UniversityEnum? university, FacultyEnum? faculty)
            : this(firstName, middleName, lastName, address, mobilePhone, email)
        {
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int SSN { get; private set; }

        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public int? Course { get; private set; }

        public SpecialtyEnum? Specialty { get; private set; }

        public UniversityEnum? University { get; private set; }

        public FacultyEnum? Faculty { get; private set; }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            var second = obj as Student;

            if (second == null)
            {
                throw new ArgumentException("Object to compare is not a Student");
            }

            if (this.SSN == second.SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Math.Abs(this.SSN.GetHashCode() ^ this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode());
        }

        public override string ToString()
        {
			// Get all properies
            var result = new StringBuilder();
            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                var currentProperty = property.GetValue(this);

				// Print only the properties which are available
                if (currentProperty != null)
                {
                    result.Append(property.GetValue(this));
                    result.Append("\n");
                }
            }

            return result.ToString();
        }

        public object Clone()
        {
            Student cloned =  new Student(
                    this.FirstName,
                    this.MiddleName,
                    this.LastName,
                    this.Address,
                    this.MobilePhone,
                    this.Email,
                    this.Course,
                    this.Specialty,
                    this.University,
                    this.Faculty
                );

            cloned.SSN = this.SSN;
            
            return cloned;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }
            else if (this.FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) < 0)
            {
                return -1;
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) > 0)
            {
                return 1;
            }
            else if (this.LastName.CompareTo(other.LastName) < 0)
            {
                return -1;
            }
            else if (this.LastName.CompareTo(other.LastName) > 0)
            {
                return 1;
            }
            else
            {
                if (this.SSN.CompareTo(other.SSN) < 0)
                {
                    return -1;
                }
                else if (this.SSN.CompareTo(other.SSN) > 0)
                {
                    return 1;   
                }
				else
                {
                    return 0;
                }
            }
        }
    }
}
