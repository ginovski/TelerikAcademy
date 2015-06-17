//Write a program that reads a string, reverses it and prints the result at the console.
namespace ReverseString
{
    using System;
    using System.Text;

    public class Program
    {
        private static string ReverseString(string str)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();
        }

        public static void Main()
        {
            string str = Console.ReadLine();
            string reversed = ReverseString(str);

            Console.WriteLine(reversed);
        }
    }
}
