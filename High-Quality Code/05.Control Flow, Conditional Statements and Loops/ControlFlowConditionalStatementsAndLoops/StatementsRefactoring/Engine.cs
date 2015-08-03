// Refactor the following if statements
namespace StatementsRefactoring
{
    using System;

    public class Engine
    {
        private const int MinRow = 0;
        private const int MaxRow = 10;
        private const int MinCol = 0;
        private const int MaxCol = 8;

        public static void Main()
        {
            // Task1
            Potato potato = new Potato();

            // some code... 
            if (potato == null)
            {
                throw new ArgumentException();
            }
            else
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            // Task2
            int row = 3;
            int col = 4;

            bool isInColRange = col <= MaxCol && col >= MinCol;
            bool isInRowRange = row >= MinRow && row <= MaxRow;
            bool shouldVisitCell = true;

            if (isInRowRange && isInColRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            // Visiting cell...
        }

        private static void Cook(Potato potato)
        {
            // Cooking...
        }
    }
}
