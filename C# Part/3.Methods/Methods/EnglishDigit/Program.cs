//Write a method that returns the last digit of given integer as an English word.
namespace EnglishDigit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigit = GetLastDigitAsWord(number);
            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            string digitAsString = "";

            switch (lastDigit)
            {
                case 0:
                    digitAsString = "Zero";
                    break;
                case 1:
                    digitAsString = "One";
                    break;
                case 2:
                    digitAsString = "Two";
                    break;
                case 3:
                    digitAsString = "Three";
                    break;
                case 4:
                    digitAsString = "Four";
                    break;
                case 5:
                    digitAsString = "Five";
                    break;
                case 6:
                    digitAsString = "Six";
                    break;
                case 7:
                    digitAsString = "Seven";
                    break;
                case 8:
                    digitAsString = "Eight";
                    break;
                case 9:
                    digitAsString = "Nine";
                    break;
            }

            return digitAsString;
        }
    }
}
