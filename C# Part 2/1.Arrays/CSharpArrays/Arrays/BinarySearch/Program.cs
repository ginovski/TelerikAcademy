//Write a program that finds the index of given element in a sorted array of integers by using the Binary search 
//algorithm(http://en.wikipedia.org/wiki/Binary_search_algorithm).
namespace BinarySearch
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 2, 2, 5, 6, 8, 4, 1, 3, 5 };
            Array.Sort(numbers);

            int indexMin = 0;
            int indexMax = numbers.Length - 1;

            Console.Write("Write a number you want to find in the array: ");
            int keyToBeFound = int.Parse(Console.ReadLine());

            bool found = false;

            while (indexMax >= indexMin)
            {
                int indexMid = indexMin + ((indexMax - indexMin) / 2);
                if (numbers[indexMid] == keyToBeFound)
                {
                    Console.WriteLine("Number {0} is found at index {1}", keyToBeFound, indexMid);
                    found = true;
                    break;
                }
                else if (numbers[indexMid] < keyToBeFound)
                {
                    indexMin = indexMid + 1;
                }
                else
                {
                    indexMax = indexMid - 1;
                }
            }
            if (!found)
            {
                Console.WriteLine("Number {0} is not found {1}",keyToBeFound, -1);
            }
        }
    }
}
