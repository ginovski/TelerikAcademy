//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
namespace MaximalSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int sum = 0;
            int[] numbersWithMaxSum = new int[k];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int index = 0;
            for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
            {
                numbersWithMaxSum[index] = numbers[i];
                sum += numbers[i];
                index++;
            }

            Console.WriteLine("Numbers with max sum: {0}", string.Join(", ", numbersWithMaxSum));
            Console.WriteLine("Max sum: {0}", sum);
        }
    }
}
