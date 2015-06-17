//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
namespace MaximalSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[,] numbers =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };
            int[,] biggestSumMatrix = new int[3, 3];

            int sum = 0;
            int biggestSum = int.MinValue;

            for (int row = 0; row < numbers.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < numbers.GetLength(1) - 2; col++)
                {
                    sum = numbers[row, col] + numbers[row + 1, col] + numbers[row + 2, col] + numbers[row, col + 1] + numbers[row, col + 2] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;

                        biggestSumMatrix[0, 0] = numbers[row, col];
                        biggestSumMatrix[0, 1] = numbers[row, col + 1];
                        biggestSumMatrix[0, 2] = numbers[row, col + 2];
                        biggestSumMatrix[1, 0] = numbers[row + 1, col];
                        biggestSumMatrix[1, 1] = numbers[row + 1, col + 1];
                        biggestSumMatrix[1, 2] = numbers[row + 1, col + 2];
                        biggestSumMatrix[2, 0] = numbers[row + 2, col];
                        biggestSumMatrix[2, 1] = numbers[row + 2, col + 1];
                        biggestSumMatrix[2, 2] = numbers[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine("Biggest sum is: {0}", biggestSum);
            Console.WriteLine("3x3 part of the biggest sum: ");

            for (int row = 0; row < biggestSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < biggestSumMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", biggestSumMatrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
