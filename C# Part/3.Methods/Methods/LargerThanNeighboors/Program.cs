//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
namespace LargerThanNeighboors
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 8, 15, 10, 6 };
            int index = 6;

            bool isLargerThanNeighboors = IsLargerThanNeighboors(numbers, index);

            Console.WriteLine("Is number at index {0} larger than its neighboors? ---> {1}", index, isLargerThanNeighboors);
        }

        private static bool IsLargerThanNeighboors(int[] numbers, int index)
        {
            if (index == 0 || index == numbers.Length - 1)
            {
                Console.WriteLine("There are no 2 neighboors!");
                return false;
            }

            if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
