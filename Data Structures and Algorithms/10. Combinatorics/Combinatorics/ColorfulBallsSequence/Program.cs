// 04. Редица цветни топчета
// http://bgcoder.com/Contests/Practice/Index/132#3
namespace ColorfulBallsSequence
{
    using System;
    using System.Numerics;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string balls = Console.ReadLine();
            int[] groups = new int[26];

            foreach (var ball in balls)
            {
                groups[ball - 'A']++;
            }

            int n = balls.Length;

            BigInteger[] factorials = new BigInteger[n + 1];
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

            Console.WriteLine(result);
        }
    }
}