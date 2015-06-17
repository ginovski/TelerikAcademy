//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
namespace BinarySearch
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 4, 1, 8, 15, 6, 25, 43, 30 };
            int k = int.Parse(Console.ReadLine());

            Array.Sort(numbers);

            int largestNumber = k;
            while (Array.BinarySearch(numbers, largestNumber) < 0)
            {
                largestNumber--;
            }

            Console.WriteLine("Largest number <= K({0}) is {1}",k, largestNumber);
        }
    }
}
