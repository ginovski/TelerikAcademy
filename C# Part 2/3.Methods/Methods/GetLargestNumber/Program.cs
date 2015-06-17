//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
namespace GetLargestNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxFromFirstAndSecond = GetMax(firstNumber, secondNumber);
            int maxNumber = GetMax(maxFromFirstAndSecond, thirdNumber);

            Console.WriteLine("Largest number is {0}", maxNumber);
        }

        private static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
