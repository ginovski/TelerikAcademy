using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = number % 2 == 0;
        Console.WriteLine("The number is even - {0}", result);
    }
}

