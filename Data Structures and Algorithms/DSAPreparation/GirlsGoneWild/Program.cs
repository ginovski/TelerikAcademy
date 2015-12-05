using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlsGoneWild
{
    internal class Program
    {
        private static char[] letters;

        private static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string lettersLine = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            letters = lettersLine.ToCharArray();

            Solve();
        }

        private static void Solve()
        {
        }
    }
}