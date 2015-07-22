//C# Exam task 3
namespace LoverOf2
{
    using System;
    using System.Linq;
    using System.Numerics;

    using LoverOf2.Utillities;

    public class Start
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int numberofDirections = int.Parse(Console.ReadLine());
            string pathPositionsAsString = Console.ReadLine();

            int[] pathPositions = ParsingUtillities.ParsePathPositions(pathPositionsAsString);

            BigInteger[,] field = MatrixUtillities.FillMatrix(rows, cols);
            BigInteger sum = MatrixUtillities.CalculateSum(pathPositions, field);

            Console.WriteLine(sum);
        }
    }
}
