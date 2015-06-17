//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
namespace IndexOfLetters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string word = Console.ReadLine();

            //Make all letters lower case, if user enters word in CAPS LOCK
            word = word.ToLower(); 

            Console.WriteLine("Indexes of each letter are: ");
            foreach (var letter in word)
            {
                Console.Write("{0}  ", Array.IndexOf(letters, letter));
            }
            Console.WriteLine();
        }
    }
}
