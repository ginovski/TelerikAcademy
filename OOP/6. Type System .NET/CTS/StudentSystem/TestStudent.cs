namespace StudentSystem
{
    using System;

    public class TestStudent
    {
        public static void Main()
        {
            Student pesho = new Student("Pesho", "Peshov", "Peshovski", "ul. Specialna", "0888456123", "pesho@abv.bg", 5, SpecialtyEnum.Architect, UniversityEnum.SofiaUniversity, FacultyEnum.Informatics);
            Student gosho = new Student("Gosho", "Goshov", "Goshovski");

            Console.WriteLine(pesho.GetHashCode());
            //Console.WriteLine(pesho);
            //Console.WriteLine(gosho);

            Student clonedPesho = pesho.Clone() as Student;

            Console.WriteLine(pesho.CompareTo(gosho));
            Console.WriteLine(pesho.CompareTo(clonedPesho));
        }
    }
}
