using System;

class SumOfNAndX
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);

        input = Console.ReadLine();
        int x = int.Parse(input);

        double nFactorial = 1;
        double powX = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            powX = Math.Pow(x, i);
            sum += nFactorial / powX;
        }
        Console.WriteLine(sum);
    }
}

