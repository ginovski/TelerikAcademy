using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Election
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            var answer = Solve(numbers, k);
            Console.WriteLine(answer);
        }

        private static BigInteger Solve(List<int> numbers, int k)
        {
            BigInteger[] sums = new BigInteger[numbers.Sum() + 1];
            sums[0] = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = numbers.Sum(); j >= 0; j--)
                {
                    if (sums[j] != 0)
                    {
                        sums[j + numbers[i]] += sums[j];
                    }
                }
            }

            BigInteger answer = 0;
            for (int i = k; i <= numbers.Sum(); i++)
            {
                answer += sums[i];
            }

            return answer;
        }
    }
}