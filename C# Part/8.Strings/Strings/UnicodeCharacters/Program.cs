//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
namespace UnicodeCharacters
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string encoded = EncodeText(text);

            Console.WriteLine(encoded);
        }

        private static string EncodeText(string text)
        {
            var encoded = new StringBuilder();
            foreach (var ch in text)
            {
                string formated = "\\u" + string.Format("{0:X}",(int) ch).PadLeft(4, '0');
                encoded.Append(formated);
            }

            return encoded.ToString();
        }
    }
}
