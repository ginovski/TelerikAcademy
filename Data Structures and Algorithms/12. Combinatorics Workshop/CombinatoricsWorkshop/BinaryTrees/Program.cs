using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    internal class Program
    {
        private static BigInteger[] factorials;

        private static void Main(string[] args)
        {
            string buckets = Console.ReadLine();
            int[] groups = new int[26];

            foreach (var bucket in buckets)
            {
                groups[bucket - 'A']++;
            }

            int n = buckets.Length;

            factorials = new BigInteger[2 * n + 1];
            factorials[0] = 1;

            for (int i = 1; i < factorials.Length; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }

            BigInteger result = factorials[n];
            foreach (var group in groups)
            {
                result /= factorials[group];
            }

            BigInteger numberOfTrees = GetNumberOfTrees(n);

            Console.WriteLine(result * numberOfTrees);
        }

        private static BigInteger GetNumberOfTrees(int n)
        {
            return factorials[2 * n] / (factorials[n + 1] * factorials[n]);
        }
    }
}