// Problem 2. IEnumerable extensions
// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class TestExtensions
    {
        private static void Main()
        {
            var numbers = new List<double>() { 1, 2, 3, 4, 5, 6};
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Average());
        }
    }
}
