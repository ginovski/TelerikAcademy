//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
namespace SayHello
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
