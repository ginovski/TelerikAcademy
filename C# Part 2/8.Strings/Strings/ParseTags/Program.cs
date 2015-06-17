//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
namespace ParseTags
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string parsedText = ParseText(text);

            Console.WriteLine(parsedText);
        }

        private static string ParseText(string text)
        {
            //TODO: Implement
            return "";
        }
    }
}
