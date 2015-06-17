//Write a method that reverses the digits of given decimal number.
namespace NumberReverser
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            decimal reversed = ReverseNumber(number);

            Console.WriteLine(reversed);
        }

        private static decimal ReverseNumber(decimal number)
        {
            string reversed = "";
            string numberAsString = number.ToString();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversed += numberAsString[i];
            }

            return decimal.Parse(reversed);
        }
    }
}
