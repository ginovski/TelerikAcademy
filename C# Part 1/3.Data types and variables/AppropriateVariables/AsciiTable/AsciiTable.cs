using System;

class AsciiTable
{
    static void Main()
    {
        for (int i = 33; i < 127; i++)
        {
            Console.WriteLine("ASCII code {0}: {1}", i, (char)i);
        }
    }
}
