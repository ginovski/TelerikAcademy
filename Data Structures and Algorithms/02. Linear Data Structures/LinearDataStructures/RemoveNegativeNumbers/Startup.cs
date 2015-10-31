// Write a program that removes from given sequence all negative numbers.
namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<int>() { 1, 2, -3, 5, -4, 16, -50, 30 };

            numbers.RemoveAll(n => n < 0);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}