using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSubsequences
{
    internal class Program
    {
        private static int[] comb;
        private static int sum;

        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = line1[0];
                int k = line1[1];

                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                comb = new int[k];
                sum = 0;

                Comb(numbers, comb, 0, 0, k);
                Console.WriteLine(sum);
            }
        }

        private static void Comb(int[] numbers, int[] comb, int index, int start, int k)
        {
            if (index >= k)
            {
                sum += comb.Sum();
            }
            else
            {
                for (int i = start; i < numbers.Length; i++)
                {
                    comb[index] = numbers[i];
                    Comb(numbers, comb, index + 1, i + 1, k);
                }
            }
        }
    }
}