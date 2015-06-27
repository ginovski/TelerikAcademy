namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private const int MAX = 35;

        private static Random random = new Random();

        private static void GetHighscore(List<Player> players)
        {
            Console.WriteLine("\nHighscore:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty highscore\n");
            }
        }

        private static void Play(char[,] field, char[,] mines, int row, int col)
        {
            char minesCount = GetMinesCount(mines, row, col);

            mines[row, col] = minesCount;
            field[row, col] = minesCount;
        }

        private static void PrintField(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateField()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMinesOnTheField()
        {
            int rows = 5;
            int cols = 10;

            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> randomPositions = new List<int>();
            while (randomPositions.Count < 15)
            {
                int randomNumber = random.Next(50);
                if (!randomPositions.Contains(randomNumber))
                {
                    randomPositions.Add(randomNumber);
                }
            }

            foreach (int position in randomPositions)
            {
                int col = position / cols;
                int row = position % cols;

                if (row == 0 && position != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static void PrintMinesCount(char[,] field)
        {
            int row = field.GetLength(0);
            int col = field.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char minesCount = GetMinesCount(field, i, j);

                        field[i, j] = minesCount;
                    }
                }
            }
        }

        private static char GetMinesCount(char[,] mines, int row, int col)
        {
            int minesCount = 0;

            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    minesCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    minesCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[row, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            return char.Parse(minesCount.ToString());
        }

        private static void Main()
        {
            string command = string.Empty;

            char[,] field = GenerateField();
            char[,] mines = PlaceMinesOnTheField();

            int minesCount = 0;
            int row = 0;
            int col = 0;

            bool steppedOnAMine = false;
            bool isNewGame = true;
            bool wonTheGame = false;

            List<Player> winners = new List<Player>(6);
            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Minesweeper" +
                    "\nCommand 'top' - highscore, 'restart' - start new game, 'exit' - leave the game");
                    PrintField(field);
                    isNewGame = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) && row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetHighscore(winners);
                        break;
                    case "restart":
                        field = GenerateField();
                        mines = PlaceMinesOnTheField();
                        PrintField(field);

                        steppedOnAMine = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye.");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                Play(field, mines, row, col);
                                minesCount++;
                            }

                            if (MAX == minesCount)
                            {
                                wonTheGame = true;
                            }
                            else
                            {
                                PrintField(field);
                            }
                        }
                        else
                        {
                            steppedOnAMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command\n");
                        break;
                }

                if (steppedOnAMine)
                {
                    PrintField(mines);
                    Console.Write("\nYou lose with {0} points. " + "Enter your name: ", minesCount);

                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, minesCount);

                    if (winners.Count < 5)
                    {
                        winners.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < player.Points)
                            {
                                winners.Insert(i, player);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }

                    winners.Sort((Player playerOne, Player playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    winners.Sort((Player playerOne, Player playerTwo) => playerTwo.Points.CompareTo(playerOne.Points));

                    GetHighscore(winners);

                    field = GenerateField();
                    mines = PlaceMinesOnTheField();

                    minesCount = 0;
                    steppedOnAMine = false;
                    isNewGame = true;
                }

                if (wonTheGame)
                {
                    Console.WriteLine("\nYou didn't find a mine! Congratulations");

                    PrintField(mines);

                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, minesCount);
                    winners.Add(player);

                    GetHighscore(winners);

                    field = GenerateField();
                    mines = PlaceMinesOnTheField();
                    minesCount = 0;
                    wonTheGame = false;
                    isNewGame = true;
                }
            } 
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Goodbye");
            Console.Read();
        }
    }
}
