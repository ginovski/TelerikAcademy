// Write a program that reads from the console a sequence of positive integer numbers.
// The sequence ends when empty line is entered.
// Calculate and print the sum and average of the elements of the sequence.
// Keep the sequence in List<int>
namespace SumAndAverageOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static int Average(IEnumerable<int> numbers)
        {
            int sum = Sum(numbers);

            return sum / numbers.Count();
        }

        private static int Sum(IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static void Main()
        {
            var numbers = new List<int>();

            string line = Console.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                int number = int.Parse(line);
                numbers.Add(number);

                line = Console.ReadLine();
            }

            int sum = Sum(numbers);
            int average = Average(numbers);

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", average);
        }
    }
}