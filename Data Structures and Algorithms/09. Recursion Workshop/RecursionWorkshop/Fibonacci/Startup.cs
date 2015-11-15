namespace Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static Dictionary<long, long> numbers = new Dictionary<long, long>();

        public static long FibonacciSolver(long n)
        {
            if (!numbers.ContainsKey(n))
            {
                if (n == 1 || n == 2)
                {
                    return 1;
                }

                long result = (FibonacciSolver(n - 1) + FibonacciSolver(n - 2)) % 1000000007;
                numbers[n] = result;

                return result;
            }
            else
            {
                return numbers[n];
            }
        }

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(FibonacciSolver(n));
        }
    }
}