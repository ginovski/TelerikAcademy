using System;

class KaspichaniaBoats
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int N = int.Parse(input);
        int dots = N;
        int asterisk = 1;
        int dotsTopSide = N - 1;
        int dotsTopMid = 0;
        int midAsterisk = (N * 2) + 1;
        int dotsBotSide = 1;
        int dotsBotMid = N - 2;
        Console.Write(new string('.', dots));
        Console.Write(new string('*', asterisk));
        Console.WriteLine(new string('.', dots));

        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', dotsTopSide));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.WriteLine(new string('.', dotsTopSide));
            dotsTopMid++;
            dotsTopSide--;
        }

        Console.WriteLine(new string('*', midAsterisk));

        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', dotsBotSide));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsBotMid));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsBotMid));
            Console.Write(new string('*', asterisk));
            Console.WriteLine(new string('.', dotsBotSide));
            dotsBotSide++;
            dotsBotMid--;
        }

        Console.Write(new string('.', dotsBotSide));
        Console.Write(new string('*', N));
        Console.WriteLine(new string('.', dotsBotSide));
    }
}

