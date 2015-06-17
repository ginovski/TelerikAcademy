using System;

class _3Bit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = 3; 
        int mask = 1 << position ;
        int numAndMask = number & mask;
        int bit = numAndMask >> 3;
        Console.WriteLine("The bit in the 3rd position is {0}", bit);
    }
}

