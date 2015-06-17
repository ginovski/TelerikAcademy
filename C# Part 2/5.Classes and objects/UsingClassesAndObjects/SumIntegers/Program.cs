//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
namespace SumIntegers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = "43 68 9 23 318";
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += int.Parse(number);   
            }

            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
