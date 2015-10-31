// Write a program that removes from given sequence all numbers that occur odd number of times.
// Example:
// { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
namespace RemoveNumbersThatOccuresOddNumberOfTimes
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

        public static void Main()
        {
            var numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var occurences = FindOccurences(numbers);

            foreach (var occurence in occurences)
            {
                if (occurence.Value % 2 != 0)
                {
                    numbers.RemoveAll(n => n == occurence.Key);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}