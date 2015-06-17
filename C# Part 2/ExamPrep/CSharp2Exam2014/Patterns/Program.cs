using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                string[] row = input.Split(' ');
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = int.Parse(row[cols]);
                }
            }
        }
    }
}
