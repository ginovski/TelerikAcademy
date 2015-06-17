using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int N = int.Parse(input);
        int dotsTop = (N / 2) + 1;
        int asteriskTop = N;
        int dotsTopSide = N / 2;
        int dotsTopMid = N / 2;
        int asterisk = 1;
        int asteriskMid = (N * 2) + 1;
        int dots = N;
        Console.Write(new string('.', dotsTop));
        Console.Write(new string('*', asteriskTop));
        Console.WriteLine(new string('.', dotsTop));

        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', dotsTopSide));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.WriteLine(new string('.', dotsTopSide));
            dotsTopSide--;
            dotsTopMid++;
        }
        Console.WriteLine(new string('*', asteriskMid));

        for (int i = 0; i < N - 1; i++)
        {
            dotsTopSide++;
            dotsTopMid--;
            Console.Write(new string('.', dotsTopSide));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dotsTopMid));
            Console.Write(new string('*', asterisk));
            Console.WriteLine(new string('.', dotsTopSide));
        }
        Console.Write(new string('.', dots));
        Console.Write(new string('*', asterisk));
        Console.WriteLine(new string('.', dots));
    }
}

