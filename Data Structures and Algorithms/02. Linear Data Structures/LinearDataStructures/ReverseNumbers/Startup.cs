// Write a program that reads N integers from the console and reverses them using a stack.
// Use the Stack<int> class.
namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new Stack<int>();

            Console.Write("Write N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers.Push(number);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}