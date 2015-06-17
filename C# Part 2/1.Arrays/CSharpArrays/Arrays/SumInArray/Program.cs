//Write a program that finds in given array of integers a sequence of given sum S (if present).
namespace SumInArray
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = new int[] { 6, 3, 1, 4, 2, 5, 8 };
            int sum = int.Parse(Console.ReadLine());
            int equalSum = 0;
            int startIndex = 0;
            int endIndex = 1;

            bool isSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                equalSum = numbers[i];
                startIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    equalSum += numbers[j];
                    endIndex = j;

                    if (equalSum == sum)
                    {
                        Console.WriteLine("Numbers that makes sum {0} are: ", sum);
                        Console.Write("{");
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.Write(numbers[k] + " ");
                        }
                        Console.WriteLine("}");
                        isSum = true;
                    }
                }
            }

            if (!isSum)
            {
                Console.WriteLine("None of the numbers makes sum {0}", sum);
            }
        }
    }
}
