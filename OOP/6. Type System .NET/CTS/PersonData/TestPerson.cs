namespace PersonData
{
    using System;

    public class TestPerson
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho");
            Person peshoWithAge = new Person("Pesho", 15);

            Console.WriteLine(pesho);
            Console.WriteLine(peshoWithAge);
        }
    }
}
