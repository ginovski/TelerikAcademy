// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// 1	8	9	16
// 2	7	10	15
// 3	6	11	14
// 4	5	12	13
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
                if (col % 2 != 0)
                {
                    for (int row = numbers.GetLength(0) - 1; row >= 0; row--)
                    {
                        numbers[row, col] = counter++;
                    }
                }
                else
                {
                    for (int row = 0; row < numbers.GetLength(0); row++)
                    {
                        numbers[row, col] = counter++;
                    }
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
