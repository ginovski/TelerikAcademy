// Link to the task http://bgcoder.com/Contests/Practice/Index/123#1
namespace SuperSum
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input[0];
            int n = input[1];

            int result = CalculateSuperSum(k, n);

            Console.WriteLine(result);
        }

        private static int CalculateSuperSum(int k, int n)
        {
            int result = 0;

            if (k == 0)
            {
                return n;
            }

            for (int i = 1; i <= n; i++)
            {
                result += CalculateSuperSum(k - 1, i);
            }

            return result;
        }
    }
}