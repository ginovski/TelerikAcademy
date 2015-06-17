//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
namespace IntegerCalculations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Numbers: 1, 2, 3, 4, 5, 6");
            Console.WriteLine("Average: {0}", Average(1, 2, 3, 4, 5, 6));
            Console.WriteLine("Sum: {0}", Sum(1, 2, 3, 4, 5, 6));
            Console.WriteLine("Product: {0}", Product(1, 2, 3, 4, 5, 6));
            Console.WriteLine("Min: {0}", Min(1, 2, 3, 4, 5, 6));
            Console.WriteLine("Max: {0}", Max(1, 2, 3, 4, 5, 6));
        }

        private static decimal Average(params int[] numbers)
        {
            decimal sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }

        private static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        private static int Product(params int[] numbers)
        {
            int product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }

        private static int Min(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        private static int Max(params int[] numbers)
        {
            int max = int.MinValue;

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }
}
