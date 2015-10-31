// Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.
// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2 → 2 times
// 3 → 4 times
// 4 → 3 times
namespace NumbersOccursCount
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
            var numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var occurences = FindOccurences(numbers);

            foreach (var occurence in occurences)
            {
                Console.WriteLine("{0} -> {1}", occurence.Key, occurence.Value);
            }
        }
    }
}