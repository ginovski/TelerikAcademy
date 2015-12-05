using System;
using System.Collections.Generic;

namespace Divisors
{
    internal class Program
    {
        private static List<int[]> permutations = new List<int[]>();

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] perm = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                perm[i] = number;
            }

            Perm(perm, 0);
            var numberWithMinDivisors = -1;
            foreach (var permutation in permutations)
            {
                var number = int.Parse(string.Join("", permutation));
                if (numberWithMinDivisors == -1)
                {
                    numberWithMinDivisors = number;
                }

                int divisors = Divisors(number);
                int minDivisors = Divisors(numberWithMinDivisors);
                if (divisors < minDivisors)
                {
                    numberWithMinDivisors = number;
                }
                else if (divisors == minDivisors)
                {
                    numberWithMinDivisors = Math.Min(numberWithMinDivisors, number);
                }
            }

            Console.WriteLine(numberWithMinDivisors);
        }

        private static void Perm(int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                permutations.Add((int[])arr.Clone());
            }
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }

        private static int Divisors(int x)
        {
            int limit = x;
            int numberOfDivisors = 0;

            if (x == 1) return 1;

            for (int i = 1; i < limit; ++i)
            {
                if (x % i == 0)
                {
                    limit = x / i;
                    if (limit != i)
                    {
                        numberOfDivisors++;
                    }
                    numberOfDivisors++;
                }
            }

            return numberOfDivisors;
        }
    }
}