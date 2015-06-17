// Problem 3. Animal hierarchy

// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var animals = new List<Animal>()
            {
                new Cat("Pesho", 3, Sex.Female),
                new Dog("Stamat", 5, Sex.Male),
                new Frog("Jabka", 8, Sex.Male),
                new Kitten("Kotio", 7),
                new Tomcat("Kotarakus", 10),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            double averageAge = animals.Average(a => a.Age);
            Console.WriteLine("Average age --> {0}", averageAge);
        }
    }
}
