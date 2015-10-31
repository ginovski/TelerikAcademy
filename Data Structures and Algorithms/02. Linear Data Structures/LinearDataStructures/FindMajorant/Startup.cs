// * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
// Write a program to find the majorant of given array(if exists).
// Example:
// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
namespace FindMajorant
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static IDictionary<int, int> FindOccurences(IEnumerable<int> numbers)
        {
            var occurences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!occurences.ContainsKey(number))
                {
                    occurences[number] = 0;
                }

                occurences[number]++;
            }

            return occurences;
        }

        private static int? FindMajorantNumber(IDictionary<int, int> occurences, int numbersCount)
        {
            foreach (var occurence in occurences)
            {
                if (occurence.Value >= (numbersCount / 2) + 1)
                {
                    return occurence.Key;
                }
            }

            return null;
        }

        public static void Main()
        {
            var numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var occurences = FindOccurences(numbers);
            int? majorant = FindMajorantNumber(occurences, numbers.Count);

            if (majorant == null)
            {
                Console.WriteLine("There is no majorant number");
            }
            else
            {
                Console.WriteLine("Majorant number is: {0}", majorant);
            }
        }
    }
}