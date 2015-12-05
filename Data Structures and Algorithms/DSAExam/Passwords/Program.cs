using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    internal class Program
    {
        private static int[] digits = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private static string pattern;
        private static List<int[]> passwords = new List<int[]>();

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            pattern = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            GenerateVariations(arr, 0, n);

            Console.WriteLine(string.Join("", passwords[k]));
        }

        private static void GenerateVariations(int[] arr, int index, int k)
        {
            if (index >= k)
            {
                if (MatchPattern(arr, pattern))
                {
                    passwords.Add((int[])arr.Clone());
                }
            }
            else
                for (int i = 0; i < digits.Length; i++)
                {
                    arr[index] = digits[i];
                    GenerateVariations(arr, index + 1, k);
                }
        }

        private static bool MatchPattern(int[] arr, string pattern)
        {
            bool doesMatch = true;
            for (int i = 0; i < pattern.Length; i++)
            {
                var patternSymbol = pattern[i];
                if (patternSymbol == '>')
                {
                    if (Array.IndexOf(digits, arr[i]) >= Array.IndexOf(digits, arr[i + 1]))
                    {
                        doesMatch = false;
                    }
                }
                else if (patternSymbol == '<')
                {
                    if (Array.IndexOf(digits, arr[i]) <= Array.IndexOf(digits, arr[i + 1]))
                    {
                        doesMatch = false;
                    }
                }
                else if (patternSymbol == '=')
                {
                    if (Array.IndexOf(digits, arr[i]) == Array.IndexOf(digits, arr[i + 1]))
                    {
                        doesMatch = false;
                    }
                }
            }

            return doesMatch;
        }
    }
}