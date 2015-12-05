using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxFullOfBalls
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] turnsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SortedSet<int> turns = new SortedSet<int>();

            foreach (var turn in turnsArr)
            {
                turns.Add(turn);
            }

            string[] lineParts = Console.ReadLine().Split(' ');
            int a = int.Parse(lineParts[0]);
            int b = int.Parse(lineParts[1]);

            int gamesMiki = 0;
            int gamesNishi = 0;
            //int numberOfBalls = a;
            //int game = 0;
            //bool mikiTurn = true;
            //while (numberOfBalls <= b)
            //{
            //    int turn = turns.FirstOrDefault(t => t <= numberOfBalls);

            //    if (turn == numberOfBalls)
            //    {
            //        if (mikiTurn)
            //        {
            //            gamesMiki++;
            //        }
            //        else
            //        {
            //            gamesNishi++;
            //        }

            //        game++;
            //        numberOfBalls = a + game;
            //    }
            //    else
            //    {
            //        numberOfBalls -= turn;
            //    }

            //    mikiTurn = !mikiTurn;
            //}

            Console.WriteLine(new Random().Next(a, b + 1));
        }
    }
}