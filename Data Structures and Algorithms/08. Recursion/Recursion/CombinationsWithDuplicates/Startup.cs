// Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set.Example:
// n= 3, k= 2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
namespace CombinationsWithDuplicates
{
    using System;

    public class Startup
    {
        private static int n = 3;
        private static int k = 2;
        private static int[] combination = new int[k];

        public static void Main()
        {
            GenerateCombinationsWithDuplicates(0, 1);
        }

        private static void GenerateCombinationsWithDuplicates(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    combination[index] = i;
                    GenerateCombinationsWithDuplicates(index + 1, i);
                }
            }
        }
    }
}