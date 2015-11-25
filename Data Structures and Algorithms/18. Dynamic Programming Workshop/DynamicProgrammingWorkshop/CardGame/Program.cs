using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] intervals = new int[n, n];

            for (int intervalLength = 3; intervalLength <= n; intervalLength++)
            {
                for (int i = 0; i <= n - intervalLength; i++)
                {
                    for (int j = i + 1; j < i + intervalLength - 1; j++)
                    {
                        int currentValue = (intervals[i, j] + intervals[j, i + intervalLength - 1]) + (numbers[j] * (numbers[i] + numbers[i + intervalLength - 1]));

                        if (currentValue > intervals[i, i + intervalLength - 1])
                        {
                            intervals[i, i + intervalLength - 1] = currentValue;
                        }
                    }
                }
            }

            Console.WriteLine(intervals[0, n - 1]);
        }
    }
}