// Write a recursive program for generating and printing all ordered k-element subsets from n-element set(variations Vkn).
// Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
namespace Variations
{
    using System;

    public class Startup
    {
        private static int n = 3;
        private static int k = 2;
        private static string[] set = { "hi", "a", "b" };

        private static string[] permutation = new string[k];

        public static void Main()
        {
            GenerateVariations(0);
        }

        private static void GenerateVariations(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", permutation));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    permutation[index] = set[i];
                    GenerateVariations(index + 1);
                }
            }
        }
    }
}