namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Sex sex;

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
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
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than zero");
                }

                this.age = value;
            }
        }

        public Sex Sex { get; private set; }

        public abstract string MakeSound();
    }
}
