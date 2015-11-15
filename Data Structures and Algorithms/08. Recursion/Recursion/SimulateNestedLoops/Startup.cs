// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
namespace SimulateNestedLoops
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int n = 2;
            int[] permutation = new int[n];

            SimulateLoops(permutation, 0, n);
        }

        private static void SimulateLoops(int[] permutation, int index, int n)
        {
            if (index >= permutation.Length)
            {
                Console.WriteLine(string.Join(" ", permutation));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    permutation[index] = i;
                    SimulateLoops(permutation, index + 1, n);
                }
            }
        }
    }
}