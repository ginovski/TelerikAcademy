using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    internal class Program
    {
        private class Hash
        {
            private const ulong BASE1 = 127;
            private const ulong MOD = 1000000033;

            private static ulong[] powers1;

            public static void ComputePowers(int n)
            {
                powers1 = new ulong[n + 1];
                powers1[0] = 1;

                for (int i = 0; i < n; i++)
                {
                    powers1[i + 1] = powers1[i] * BASE1 % MOD;
                }
            }

            public ulong Value1 { get; private set; }

            public Hash(string str)
            {
                this.Value1 = 0;

                foreach (char c in str)
                {
                    this.Add(c);
                }
            }

            public void Add(char c)
            {
                this.Value1 = (this.Value1 * BASE1 + c) % MOD;
            }

            public void Remove(char c, int n)
            {
                this.Value1 = (MOD + this.Value1 - powers1[n] * c % MOD) % MOD;
            }
        }

        private static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int occurences = 0;
            int preffOccurences = 0;
            int suffOccurences = 0;
            int n = text.Length;
            int m = word.Length;

            Hash.ComputePowers(m);
            int prefCount = 1;
            for (int i = 0; i < m; i++)
            {
                string prefix = word.Substring(0, prefCount);
                string suffix = word.Substring(prefCount);
                Hash prefPattern = null;
                Hash suffPattern = null;
                Hash prefwindow = null;
                Hash suffwindow = null;

                if (prefix.Length > 0)
                {
                    prefPattern = new Hash(prefix);
                    prefwindow = new Hash(text.Substring(0, prefix.Length));
                    if (prefPattern.Value1 == prefwindow.Value1)
                    {
                        preffOccurences++;
                    }
                }

                if (suffix.Length > 0)
                {
                    suffPattern = new Hash(suffix);
                    suffwindow = new Hash(text.Substring(0, suffix.Length));
                    if (suffPattern.Value1 == suffwindow.Value1)
                    {
                        suffOccurences++;
                    }
                }

                for (int j = 1; j <= n - Math.Min(prefix.Length, suffix.Length); j++)
                {
                    if (prefix.Length > 0)
                    {
                        if (j + prefix.Length - 1 <= text.Length - 1)
                        {
                            prefwindow.Add(text[j + prefix.Length - 1]);
                            prefwindow.Remove(text[j - 1], prefix.Length);

                            if (prefPattern.Value1 == prefwindow.Value1)
                            {
                                preffOccurences++;
                            }
                        }
                    }
                    if (suffix.Length > 0)
                    {
                        if (j + suffix.Length - 1 <= text.Length - 1)
                        {
                            suffwindow.Add(text[j + suffix.Length - 1]);
                            suffwindow.Remove(text[j - 1], suffix.Length);

                            if (suffPattern.Value1 == suffwindow.Value1)
                            {
                                suffOccurences++;
                            }
                        }
                    }
                }

                if (preffOccurences == 0)
                {
                    occurences += suffOccurences;
                }
                else if (suffOccurences == 0)
                {
                    occurences += preffOccurences - 1;
                }
                else
                {
                    occurences += preffOccurences * suffOccurences;
                }

                prefCount++;
                preffOccurences = 0;
                suffOccurences = 0;
            }

            Console.WriteLine(occurences + 1);
        }
    }
}