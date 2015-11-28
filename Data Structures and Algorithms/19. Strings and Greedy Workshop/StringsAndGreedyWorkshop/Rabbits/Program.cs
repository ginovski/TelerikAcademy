using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbersOfRabbits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbersOfRabbits.RemoveAt(numbersOfRabbits.Count - 1);

            int result = FindNumberOfRabbits(numbersOfRabbits);
            Console.WriteLine(result);
        }

        private static int FindNumberOfRabbits(List<int> numbersOfRabbits)
        {
            var groups = new Dictionary<int, int>();

            foreach (var number in numbersOfRabbits)
            {
                if (!groups.ContainsKey(number + 1))
                {
                    groups.Add(number + 1, 0);
                }

                groups[number + 1]++;
            }

            int rabbitsCount = 0;

            foreach (var group in groups)
            {
                int groupSize = group.Key;
                int rabbitsInGroup = group.Value;
                int groupsCount = (int)Math.Ceiling(rabbitsInGroup / (decimal)groupSize);

                rabbitsCount += groupsCount * groupSize;
            }

            return rabbitsCount;
        }
    }
}