//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
namespace FirstLargerThanNeighboors
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 8, 15, 10, 6 };
            int index = IndexOfFirstLargerThanNeighboors(numbers);

            Console.WriteLine("Numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine("Index of the first number larger than neighboors is: {0}", index);
        }

        private static int IndexOfFirstLargerThanNeighboors(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (IsLargerThanNeighboors(numbers, i))
                {
                    return i;
                }
            }

            return -1;
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
