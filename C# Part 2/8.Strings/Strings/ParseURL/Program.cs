//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
namespace ParseURL
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            string protocol = url.Substring(0, url.IndexOf(":"));

            int firstSlash = url.IndexOf("/");
            string server = url.Substring(firstSlash + 2, url.IndexOf("/", firstSlash + 2) - firstSlash - 2);
            string resource = url.Substring(url.IndexOf("/", firstSlash + 2));

            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
