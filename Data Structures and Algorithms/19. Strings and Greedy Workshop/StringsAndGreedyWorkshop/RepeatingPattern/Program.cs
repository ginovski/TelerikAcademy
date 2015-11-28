namespace RepeatingPattern
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 1; i <= s.Length; i++)
            {
                if (s.Length % i != 0)
                {
                    continue;
                }

                string pattern = s.Substring(0, i);

                bool isPattern = IsPattern(s, pattern, i);

                if (isPattern)
                {
                    Console.WriteLine(pattern);
                    break;
                }
            }
        }

        private static bool IsPattern(string s, string pattern, int length)
        {
            for (int i = length; i + length <= s.Length; i += length)
            {
                if (pattern != s.Substring(i, length))
                {
                    return false;
                }
            }

            return true;
        }
    }
}