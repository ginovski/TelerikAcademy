using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadronacciRectangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int q1 = int.Parse(Console.ReadLine());
            int q2 = int.Parse(Console.ReadLine());
            int q3 = int.Parse(Console.ReadLine());
            int q4 = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            long[] quadronacciNums = new long[rows * cols];
            quadronacciNums[0] = q1;
            quadronacciNums[1] = q2;
            quadronacciNums[2] = q3;
            quadronacciNums[3] = q4;

            var sb = new StringBuilder();

            for (int i = 0; i < rows * cols; i++)
            {
                if (i % cols == 0 && i != 0)
                {
                    sb.AppendLine();
                }

                if (i >= 4)
                {
                    quadronacciNums[i] = quadronacciNums[i - 1] +
                        quadronacciNums[i - 2] +
                        quadronacciNums[i - 3] +
                        quadronacciNums[i - 4];
                }

                if ((i + 1) % cols == 0)
                {
                    sb.Append(quadronacciNums[i]);
                }
                else
                {
                    sb.Append(quadronacciNums[i] + " ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}