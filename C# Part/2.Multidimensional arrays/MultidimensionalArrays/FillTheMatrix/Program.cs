// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// 1	5	9	13
// 2	6	10	14
// 3	7	11	15
// 4	8	12	16
namespace FillTheMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];
            int counter = 1;

            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                for (int row = 0; row < numbers.GetLength(0); row++)
                {
                    numbers[row, col] = counter++;
                }
            }

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write("{0} ", numbers[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
