// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.Example:
// {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
namespace StringsPresentingOddTimes
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static IEnumerable<string> FindTextsPresentingOddNumberOfTimes(string[] texts)
        {
            var textsWithNumberOfTimesPresenting = new Dictionary<string, int>();
            foreach (var text in texts)
            {
                if (!textsWithNumberOfTimesPresenting.ContainsKey(text))
                {
                    textsWithNumberOfTimesPresenting[text] = 0;
                }

                textsWithNumberOfTimesPresenting[text]++;
            }

            var textsPresentingOddNumberOfTimes = new List<string>();
            foreach (var textPresenting in textsWithNumberOfTimesPresenting)
            {
                if (textPresenting.Value % 2 != 0)
                {
                    textsPresentingOddNumberOfTimes.Add(textPresenting.Key);
                }
            }

            return textsPresentingOddNumberOfTimes;
        }

        public static void Main()
        {
            string[] texts = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var textsPresentingOddNumberOfTimes = FindTextsPresentingOddNumberOfTimes(texts);

            Console.WriteLine(string.Join(", ", textsPresentingOddNumberOfTimes));
        }
    }
}