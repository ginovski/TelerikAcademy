//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
namespace AppearenceCount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 2, 1, 1, 4, 5, 6, 4, 5, 3 };
            int numberToSearch = 1;

            int count = CountAppearance(numbers, numberToSearch);

            Console.WriteLine("Numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine("Number {0} appears {1} times in the array", numberToSearch, count);
        }

        private static int CountAppearance(int[] numbers, int numberToSearch)
        {
            int counter = 0;
            foreach (var number in numbers)
            {
                if (number == numberToSearch)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
