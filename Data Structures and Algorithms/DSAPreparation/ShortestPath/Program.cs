using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Program
    {
        private static char[] pathDirections;
        private static SortedSet<string> paths = new SortedSet<string>();

        private static void Main(string[] args)
        {
            string path = Console.ReadLine();
            pathDirections = path.ToCharArray();

            FindAllPaths(0);

            Console.WriteLine(paths.Count);
            foreach (var singlePath in paths)
            {
                Console.WriteLine(singlePath);
            }
        }

        private static void FindAllPaths(int index)
        {
            if (index == pathDirections.Length)
            {
                paths.Add(new string(pathDirections));
            }
            else if (pathDirections[index] != '*')
            {
                FindAllPaths(index + 1);
            }
            else
            {
                pathDirections[index] = 'L';
                FindAllPaths(index + 1);
                pathDirections[index] = 'R';
                FindAllPaths(index + 1);
                pathDirections[index] = 'S';
                FindAllPaths(index + 1);
                pathDirections[index] = '*';
            }
        }
    }
}