namespace Palindromize
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (IsPalindrome(s))
            {
                Console.WriteLine(s);
            }
            else
            {
                var result = new StringBuilder();
                int count = 1;

                result.Append(s);

                while (true)
                {
                    result.Append(ReverseString(s.Substring(0, count)));
                    if (IsPalindrome(result.ToString()))
                    {
                        break;
                    }

                    result.Clear();
                    result.Append(s);
                    count++;
                }

                Console.WriteLine(result.ToString());
            }
        }

        private static bool IsPalindrome(string s)
        {
            return s == ReverseString(s);
        }

        private static string ReverseString(string s)
        {
            return string.Join("", s.Reverse());
        }
    }
}