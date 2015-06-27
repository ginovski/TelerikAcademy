﻿namespace PersonCreator
{
    public class PersonCreatorMain
    {
        public void CreatePerson(int age)
        {
            Person person = new Person();

            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Strong man";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Girl";
                person.Gender = Gender.Female;
            }
        }
    }
}
