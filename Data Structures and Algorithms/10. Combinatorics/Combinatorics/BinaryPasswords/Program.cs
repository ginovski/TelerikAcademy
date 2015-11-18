// 01. Двоични пароли
// http://bgcoder.com/Contests/Practice/Index/132#0
namespace BinaryPasswords
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            long finalResult = 1;
            string pattern = Console.ReadLine();
            int[] missingPatterns = new int[pattern.Length];
            int missingPatternIndex = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                char sym = pattern[i];
                if (sym == '*')
                {
                    missingPatterns[missingPatternIndex]++;
                }
                else if (sym == '1' || sym == '0')
                {
                    if (i != 0 && pattern[i - 1] == '*')
                    {
                        missingPatternIndex++;
                    }
                }
            }

            if (missingPatterns[0] == 0)
            {
                Console.WriteLine(1);
                return;
            }

            foreach (var missingPatternLength in missingPatterns)
            {
                if (missingPatternLength == 0)
                {
                    break;
                }

                long result = 0;

                result += CalcVariationsCount(missingPatternLength);

                finalResult *= result;
            }

            Console.WriteLine(finalResult);
        }

        private static long CalcVariationsCount(int k)
        {
            long result = 1;

            for (int i = 0; i < k; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}