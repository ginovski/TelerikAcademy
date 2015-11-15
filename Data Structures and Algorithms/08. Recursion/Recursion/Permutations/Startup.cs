// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number  n.Example:
// n= 3 → { 1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
namespace Permutations
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int n = 3;
            int[] permutation = new int[n];
            for (int i = 0; i < n; i++)
            {
                permutation[i] = i + 1;
            }

            GeneratePermutations(permutation, 0);
        }

        private static void GeneratePermutations(int[] permutation, int index)
        {
            if (index >= permutation.Length)
            {
                Console.WriteLine(string.Join(", ", permutation));
            }
            else
            {
                GeneratePermutations(permutation, index + 1);
                for (int i = index + 1; i < permutation.Length; i++)
                {
                    Swap(ref permutation[index], ref permutation[i]);
                    GeneratePermutations(permutation, index + 1);
                    Swap(ref permutation[index], ref permutation[i]);
                }
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}