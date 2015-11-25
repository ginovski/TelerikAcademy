// Link to the task http://bgcoder.com/Contests/Practice/Index/123#0
namespace Tribonacci
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int t1 = input[0];
            int t2 = input[1];
            int t3 = input[2];
            int n = input[3];

            int[] numbers = new int[n + 1];
            numbers[0] = t1;
            numbers[1] = t2;
            numbers[2] = t3;

            for (int i = 3; i <= n; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }

            Console.WriteLine(numbers[n - 1]);
        }
    }
}