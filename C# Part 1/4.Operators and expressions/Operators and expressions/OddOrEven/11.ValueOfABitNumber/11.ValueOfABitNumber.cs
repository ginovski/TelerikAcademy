using System;

class ValueOfABitNumber
{
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int numberAndMask = i & mask;
        int bit = numberAndMask >> b;

        Console.WriteLine(bit);

    }
}

