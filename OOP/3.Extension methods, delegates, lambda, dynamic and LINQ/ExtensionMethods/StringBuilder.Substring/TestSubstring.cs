// Problem 1. StringBuilder.Substring
// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public class TestSubstring
    {
        private static void Main()
        {
            var text = new StringBuilder("Hello World!");
            var substring = text.Substring(0, 5);

            Console.WriteLine(substring);
        }
    }
}
