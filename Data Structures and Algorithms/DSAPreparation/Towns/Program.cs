using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine().Split(' ')[0]);
                numbers.Add(number);
            }

            int answer = FindAnswer(numbers);
            Console.WriteLine(answer);
        }

        private static int FindAnswer(List<int> numbers)
        {
            int[] leftToRight = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        max = Math.Max(max, leftToRight[j]);
                    }
                }

                leftToRight[i] = max + 1;
            }

            int[] rightToLeft = new int[numbers.Count];
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int max = 0;
                for (int j = numbers.Count - 1; j > i; j--)
                {
                    if (numbers[j] < numbers[i])
                    {
                        max = Math.Max(max, rightToLeft[j]);
                    }
                }

                rightToLeft[i] = max + 1;
            }

            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result = Math.Max(result, leftToRight[i] + rightToLeft[i] - 1);
            }

            return result;
        }
    }
}