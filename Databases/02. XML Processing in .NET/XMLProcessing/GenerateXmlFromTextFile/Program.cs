namespace GenerateXmlFromTextFile
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        internal static void Main()
        {
            var reader = new StreamReader("../../person.txt");
            var person = new Person();

            using (reader)
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.Phone = reader.ReadLine();
            }

            var root = new XElement("person");

            root.Add(new XElement("name", person.Name));
            root.Add(new XElement("address", person.Address));
            root.Add(new XElement("phone", person.Phone));

            var personDocument = new XDocument(root);

            personDocument.Save("../../person.xml");
            Console.WriteLine("Person saved!");
        }
    }
}