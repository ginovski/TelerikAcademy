using System;

class NumberBetween
{
    static void Main(string[] args)
    {
        string numbersInput = Console.ReadLine();
        int numberOne = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int numberTwo = int.Parse(numbersInput);
        int numbers = 0;
        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 5 == 0)
            {
                numbers++; 
            }
        }
        Console.WriteLine("Numbers between {0} and {1} which are divided by 5 with remainder 0 are {2}",numberOne, numberTwo, numbers);
    }
}

