
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
namespace ForbiddenWords
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static string CensorText(string text, IEnumerable<string> forbiddenWords)
        {
            text = text.ToLower();
           
            foreach (var word in forbiddenWords)
            {
                string censor = new string('*', word.Length);
                text = text.Replace(word.ToLower(), censor);
            }

            return text;
        }

        public static void Main()
        {
            var forbiddenWords = new List<string>() { "PHP", "CLR", "Microsoft" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string censoredText = CensorText(text, forbiddenWords);

            Console.WriteLine(censoredText);
        }
    }
}
