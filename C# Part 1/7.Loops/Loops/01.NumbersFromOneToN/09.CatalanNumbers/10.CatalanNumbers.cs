using System;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        string nInput = Console.ReadLine();
        uint n = uint.Parse(nInput);
        int nFactorial = 1;
        int nPlusOneFactorial = 1;
        int twiceNFactorial = 1;

        for (int i = 1; i <= n + 1; i++)
        {
            if (i <= n)
            {
                nFactorial *= i;
            }
            nPlusOneFactorial *= i;
        }
        for (int i = 1; i <= 2*n; i++)
        {
            twiceNFactorial *= i;
        }

        int result = twiceNFactorial/(nPlusOneFactorial * nFactorial);
        Console.WriteLine(result);
    }
}

