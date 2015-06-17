using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        string nInput = Console.ReadLine();
        int n = int.Parse(nInput);
        int number = 1;
        if (n < 20)
        {
            for (int cols = 1; cols <= n; cols++)
            {
                number = cols;
                for (int rows = 1; rows <= n; rows++)
                {
                    Console.Write(number);
                    Console.Write(" ");
                    number++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}

