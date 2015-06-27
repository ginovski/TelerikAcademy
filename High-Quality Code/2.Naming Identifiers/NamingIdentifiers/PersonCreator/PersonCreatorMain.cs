namespace PersonCreator
{
    public class PersonCreatorMain
    {
        public void CreatePerson(int age)
        {
            Person person = new Person();

            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Female;
            }
        }
    }
}
