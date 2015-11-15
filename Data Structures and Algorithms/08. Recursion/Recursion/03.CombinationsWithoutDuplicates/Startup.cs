// Modify the previous program to skip duplicates:
// n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
namespace CombinationsWithoutDuplicates
{
    using System;

    public class Startup
    {
        private static int n = 4;
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
                    GenerateCombinationsWithDuplicates(index + 1, i + 1);
                }
            }
        }
    }
}