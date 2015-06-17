//Write a program that finds the sequence of maximal sum in given array.
//Can you do it with only one loop (with single scan through the elements of the array)?
namespace MaximalSumOfRealNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int maxSum = 0;
            int sum = 0;
            int startIndex = 0;
            int endIndex = 1;

            for (int i = 0, j = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[j] <= 0)
                {
                    j++;
                }
                else if (sum + numbers[i] > maxSum)
                {
                    sum += numbers[i];
                    maxSum = sum;
                    startIndex = j;
                    endIndex = i;
                }
                else if ((i < numbers.Length - 1) && (numbers[i] + numbers[i + 1] > 0))
                {
                    sum += numbers[i];
                }
                else
                {
                    sum = 0;
                    i = j;
                    j++;
                }
            }
            Console.WriteLine("Maximal sum: {0}", maxSum);
            Console.Write("Sequence is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
