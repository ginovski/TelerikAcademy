//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
namespace StringLength
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            text = text.PadRight(20, '*');

            Console.WriteLine(text);
        }
    }
}
