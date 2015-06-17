using System;

class NAndKFactorial
{
    static void Main(string[] args)
    {
        Console.Write("N=");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        Console.Write("K=");
        input = Console.ReadLine();
        int k = int.Parse(input);

        int nFactorial = 1;
        int kFactorial = 1;

        if (k > 1 && n > k)
        {

            for (int i = 1; i < n; i++)
            {
                nFactorial *= i;
            }

            for (int j = 1; j < k; j++)
            {
                kFactorial *= j;
            }
            int result = nFactorial / kFactorial;
            Console.WriteLine("The result N!/K! is = {0}", result);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}

