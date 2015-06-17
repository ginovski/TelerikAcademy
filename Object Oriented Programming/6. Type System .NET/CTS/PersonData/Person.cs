namespace PersonData
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int? age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name { get; private set; }

        public int? Age { get; private set; }

        public override string ToString()
        {
            return this.Name + "\n"
                + (this.Age != null ? this.Age.ToString() : "Not specified");
        }
    }
}
