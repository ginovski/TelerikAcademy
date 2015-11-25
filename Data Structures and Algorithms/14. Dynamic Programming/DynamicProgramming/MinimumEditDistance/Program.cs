//Write a program to calculate the "Minimum Edit Distance" (MED) between two words.MED(x, y) is the minimal sum of costs of edit operations used to transform x to y.

//Sample costs:
//cost (replace a letter) = 1
//cost(delete a letter) = 0.9
//cost(insert a letter) = 0.8
//Example:
//x = "developer", y = "enveloped" → cost = 2.7
//delete ‘d’: "developer" → "eveloper", cost = 0.9
//insert ‘n’: "eveloper" → "enveloper", cost = 0.8
//replace ‘r’ → ‘d’: "enveloper" → "enveloped", cost = 1
namespace MinimumEditDistance
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string first = "developer";
            string second = "enveloped";

            double[,] table = new double[first.Length + 1, second.Length + 1];

            for (int i = 0; i <= first.Length; i++)
            {
                table[i, 0] = i * 0.9;
            }

            for (int i = 0; i <= second.Length; i++)
            {
                table[0, i] = i * 0.8;
            }

            for (int i = 1; i <= first.Length; i++)
            {
                for (int j = 1; j <= second.Length; j++)
                {
                    double replace = 1;

                    if (first[i - 1] == second[j - 1])
                    {
                        replace = 0;
                    }

                    table[i, j] = Math.Min(Math.Min(table[i - 1, j] + 0.9, table[i, j - 1] + 0.8), table[i - 1, j - 1] + replace);
                }
            }

            Console.WriteLine(table[first.Length, second.Length]);
        }
    }
}