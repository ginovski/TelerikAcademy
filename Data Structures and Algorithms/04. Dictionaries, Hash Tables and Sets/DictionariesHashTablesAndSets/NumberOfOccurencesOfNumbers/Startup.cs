// Write a program that counts in a given array of double values the number of occurrences of each value.Use Dictionary<TKey, TValue>.
// Example: array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
// -2.5 -> 2 times
// 3 -> 4 times
// 4 -> 3 times
namespace NumberOfOccurencesOfNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static IDictionary<double, int> FindOccurences(double[] numbers)
        {
            var numbersWithOccurences = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!numbersWithOccurences.ContainsKey(number))
                {
                    numbersWithOccurences[number] = 0;
                }

                numbersWithOccurences[number]++;
            }

            return numbersWithOccurences;
        }

        public static void Main()
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var numbersWithOccurences = FindOccurences(numbers);

            foreach (var occurence in numbersWithOccurences)
            {
                Console.WriteLine("{0} -> {1} times", occurence.Key, occurence.Value);
            }
        }
    }
}