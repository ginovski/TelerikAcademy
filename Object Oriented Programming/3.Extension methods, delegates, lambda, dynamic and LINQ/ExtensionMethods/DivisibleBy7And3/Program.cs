// Problem 6. Divisible by 7 and 3
// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var numbers = new List<int>();
            for (int i = 1; i <= 30; i++)
            {
                numbers.Add(i);
            }

            //with extension methods
            Console.WriteLine("Extension methods");
            var numbersDivisibleBy7And3 = numbers.Where(num => num % 3 == 0 || num % 7 == 0);
            Console.WriteLine(string.Join(",", numbersDivisibleBy7And3));
            Console.WriteLine();

            //with LINQ
            Console.WriteLine("LINQ");
            var numbersDivisibleBy7And3Linq = from num in numbers
                                              where num % 3 == 0 || num % 7 == 0
                                              select num;
            Console.WriteLine(string.Join(",", numbersDivisibleBy7And3Linq));
        }
    }
}
