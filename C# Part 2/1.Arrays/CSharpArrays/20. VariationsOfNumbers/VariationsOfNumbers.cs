using System;

class VariationsOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int firstNum = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{");
                Console.Write("{0}" + "," + " ", firstNum, j);
                Console.Write("{0}", p);
                Console.Write("}");
            }
            firstNum++;
        }
        Console.WriteLine();
    }
}

