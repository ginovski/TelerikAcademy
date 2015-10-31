// Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
// Write a program to test whether the method works correctly.
namespace LongestSubsequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static List<int> FindLongestSubsequenceOfEqualElements(List<int> numbers)
        {
            var subsequence = new List<int>();

            int count = 0;
            int maxCount = 0;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        endIndex = i;
                        startIndex = endIndex - count;
                    }

                    count = 0;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                subsequence.Add(numbers[i]);
            }

            return subsequence;
        }

        public static void Main()
        {
            var numbers = new List<int>() { 1, 2, 2, 2, 3, 4, 4, 4, 4, 5, 5 };

            var longestSubsequence = FindLongestSubsequenceOfEqualElements(numbers);

            Console.WriteLine(string.Join(", ", longestSubsequence));
        }
    }
}