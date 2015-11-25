//Write a program based on dynamic programming to solve the "Knapsack Problem": you are given N products, each has weight Wi and costs Ci and a knapsack of capacity M and you want to put inside a subset of the products with highest cost and weight ≤ M.The numbers N, M, Wi and Ci are integers in the range[1..500].

//Example: M=10kg, N=6, products:
//beer – weight=3, cost=2
//vodka – weight=8, cost=12
//cheese – weight=4, cost=5
//nuts – weight=1, cost=4
//ham – weight=2, cost=3
//whiskey – weight=8, cost=13
//Optimal solution:
//nuts + whiskey
//weight = 9
//cost = 17
namespace KnapSackProblem
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 6;
            int maxWeight = 10;

            int[] prices = { 2, 12, 5, 4, 3, 13 };
            int[] weights = { 3, 8, 4, 1, 2, 8 };

            int[,] dpTable = new int[n, maxWeight];

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < maxWeight; j++)
                {
                    if (weights[i] <= j)
                    {
                        dpTable[i, j] = Math.Max(dpTable[i - 1, j], dpTable[i - 1, j - weights[i]] + prices[i]);
                    }
                    else
                    {
                        dpTable[i, j] = dpTable[i - 1, j];
                    }
                }
            }

            Console.WriteLine("Max cost: {0}", dpTable[n - 1, maxWeight - 1]);
        }
    }
}