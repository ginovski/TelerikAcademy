using System;

class FibbonaciSequence
{
    static void Main(string[] args)
    {
        ulong previousNumber = 0;
        ulong numberTwo = 1;
        ulong numberThree;
        Console.WriteLine(previousNumber);
        Console.WriteLine(numberTwo);
        for (int i = 1; i < 99; i++ )
        {
            numberThree = previousNumber + numberTwo;
            Console.WriteLine(numberThree);
            previousNumber = numberTwo;
            numberTwo = numberThree;
        }
    }
}

