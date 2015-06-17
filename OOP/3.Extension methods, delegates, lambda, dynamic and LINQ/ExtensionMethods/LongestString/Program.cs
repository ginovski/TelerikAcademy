// Problem 17. Longest string

// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main(string[] args)
        {
            var strings = new List<string>() { "asdasd", "pesho", "askdhaskjdgasjdgasd", "1" };
            string stringWithMaxLength = (from str in strings
                                          orderby str.Length descending
                                          select str).ToArray()[0];

            Console.WriteLine("String with max length is {0}", stringWithMaxLength);
        }
    }
}
