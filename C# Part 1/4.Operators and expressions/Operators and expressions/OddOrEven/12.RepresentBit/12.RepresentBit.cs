using System;

class RepresentBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Write 0 or 1");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Write position");
		int p = int.Parse(Console.ReadLine());
        int mask = v << p;
        int result = n | mask;

        Console.WriteLine("The result is - {0}", result);
	    
    }
}

