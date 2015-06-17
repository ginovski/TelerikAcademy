//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
namespace SortByStringLength
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] strings = { "asdhasjdasgdasd", "pesho", "stamatt", "grishataaaa", "ilarioncho",  };
            Array.Sort(strings, (x, y) => (x.Length.CompareTo(y.Length)));

            Console.WriteLine(string.Join(", ", strings));
        }
    }
}
