namespace LoverOf2
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int numberofDirections = int.Parse(Console.ReadLine());
            int[] pathPositions = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            BigInteger[,] field = FillMatrix(rows, cols);
            BigInteger sum = CalculateSum(pathPositions, field);
            Console.WriteLine(sum);
        }

        private static BigInteger CalculateSum(int[] pathPositions, BigInteger[,] field)
        {
            BigInteger sum = 0;

            int rows = field.GetLength(0);
            int cols = field.GetLength(1);
            int pawnPositionRow = field.GetLength(0) - 1;
            int pawnPositionCol = 0;

            for (int i = 0; i < pathPositions.Length; i++)
            {
                int coeff = Math.Max(rows, cols);
                int pathRow = pathPositions[i] / coeff;
                int pathCol = pathPositions[i] % coeff;
                if (i == 0)
                {
                    if (pawnPositionRow > pathRow)
                    {
                        for (int row = pawnPositionRow; row >= pathRow; row--)
                        {
                            if (field[row, pawnPositionCol] != -1)
                            {
                                sum += field[row, pawnPositionCol];
                                field[row, pawnPositionCol] = -1;
                            }
                        }
                        pawnPositionRow = pathRow;
                    }
                    else
                    {
                        for (int col = pawnPositionCol; col >= pathRow; col--)
                        {
                            if (field[pawnPositionRow, col] != -1)
                            {
                                sum += field[pawnPositionRow, col];
                                field[pawnPositionRow, col] = -1;
                            }
                        }
                        pawnPositionRow = pathRow;
                    }

                }
                else
                {

                    for (int row = pawnPositionRow - 1; row >= pathRow; row--)
                    {
                        if (field[row, pawnPositionCol] != -1)
                        {
                            sum += field[row, pawnPositionCol];
                            field[row, pawnPositionCol] = -1;
                        }

                    }

                    for (int row = pawnPositionRow + 1; row <= pathRow; row++)
                    {
                        if (field[row, pawnPositionCol] != -1)
                        {

                            sum += field[row, pawnPositionCol];
                            field[row, pawnPositionCol] = -1;
                        }
                    }

                    pawnPositionRow = pathRow;

                }
                for (int col = pawnPositionCol + 1; col <= pathCol; col++)
                {
                    if (field[pawnPositionRow, col] != -1)
                    {

                        sum += field[pawnPositionRow, col];
                        field[pawnPositionRow, col] = -1;
                    }
                }
                for (int col = pawnPositionCol - 1; col >= pathCol; col--)
                {
                    if (field[pawnPositionRow, col] != -1)
                    {
                        sum += field[pawnPositionRow, col];
                        field[pawnPositionRow, col] = -1;
                    }
                }

                pawnPositionCol = pathCol;

            }

            return sum;
        }

        private static BigInteger[,] FillMatrix(int rows, int cols)
        {
            BigInteger[,] field = new BigInteger[rows, cols];
            field[rows - 1, 0] = 1;
            for (int i = 1; i < cols; i++)
            {
                field[rows - 1, i] = field[rows - 1, i - 1] * 2;
            }

            for (int col = 0; col < cols; col++)
            {
                for (int row = rows - 2; row >= 0; row--)
                {
                    field[row, col] = field[row + 1, col] * 2;
                }
            }

            return field;
        }
    }
}
