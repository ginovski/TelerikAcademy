// Write a program for generating and printing all subsets of k strings from given set of strings.
// Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
namespace SubsetsOfStrings
{
    using System;

    public class Startup
    {
        private static int k = 2;
        private static string[] set = { "test", "rock", "fun" };

        private static string[] subset = new string[k];

        public static void Main()
        {
            GenerateSubsets(0, 0);
        }

        private static void GenerateSubsets(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", subset));
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    subset[index] = set[i];
                    GenerateSubsets(index + 1, i + 1);
                }
            }
        }
    }
}