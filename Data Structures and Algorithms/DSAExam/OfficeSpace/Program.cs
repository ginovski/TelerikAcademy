using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSpace
{
    internal class Program
    {
        private static bool canBeCompleted;
        private static int totalTime = 0;
        private static bool[] visited;
        private static Dictionary<int, List<int>> dependencies = new Dictionary<int, List<int>>();

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] times = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            visited = new bool[times.Max() + 1];

            for (int i = 0; i < n; i++)
            {
                dependencies[times[i]] = new List<int>();

                var deps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (deps.Length == 1 && deps[0] == 0)
                {
                    continue;
                }
                else
                {
                    foreach (var dep in deps)
                    {
                        dependencies[times[i]].Add(times[dep - 1]);
                    }
                }
            }

            var s = dependencies.Sum(d => d.Value.Sum());
            if (s == 0)
            {
                Console.WriteLine(times[times.Length - 1]);
                return;
            }

            var totalTimes = new List<int>();

            var nodes = dependencies.OrderByDescending(d => d.Value.Sum()).ToList();
            foreach (var time in nodes)
            {
                if (!visited[time.Key])
                {
                    DFS(time.Key);
                    if (!canBeCompleted)
                    {
                        Console.WriteLine(totalTime);
                        return;
                    }

                    totalTimes.Add(totalTime);
                    totalTime = 0;
                }
            }

            Console.WriteLine(totalTimes.Max());
        }

        private static void DFS(int node)
        {
            canBeCompleted = true;
            var q = new Queue<int>();
            q.Enqueue(node);
            totalTime += node;
            visited[node] = true;
            while (q.Count > 0)
            {
                int current = q.Dequeue();
                int max = 0;
                if (dependencies[current].Count > 0)
                {
                    max = dependencies[current][0];
                }

                for (var i = 0; i < dependencies[current].Count; i++)
                {
                    if (visited[dependencies[current][i]])
                    {
                        canBeCompleted = false;
                        totalTime = -1;
                        return;
                    }
                    else
                    {
                        if (max <= dependencies[current][i])
                        {
                            max = dependencies[current][i];
                        }
                        else if (max <= dependencies[dependencies[current][i]].Sum() + dependencies[current][i])
                        {
                            max = dependencies[dependencies[current][i]].Sum() + dependencies[current][i];
                        }
                        else
                        {
                            q.Enqueue(dependencies[current][i]);
                            visited[dependencies[current][i]] = true;
                        }
                    }
                }

                if (max != 0)
                {
                    totalTime += max;
                }
            }
        }
    }
}