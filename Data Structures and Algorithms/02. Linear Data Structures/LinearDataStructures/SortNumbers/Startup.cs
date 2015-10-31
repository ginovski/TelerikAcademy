// Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.
namespace SortNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
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

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}