using System;

class BitInPosition
{
    static void Main(string[] args)
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = v & mask;
        int bitAndMask = bit >> p;
        bool checkBit = bitAndMask == 1;

        Console.WriteLine("The bit in position p is 1 - {0}", checkBit);
    }
}
