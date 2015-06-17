using System;
using System.Collections.Generic;

class Enigmanation
{
    static void Main(string[] args)
    {
        int input = Console.Read();
        List<int> equation = new List<int>();
        equation.Add(input); 
        for (int i = 0; i < equation.Capacity ; i++)
        {
           input = Console.Read();
           equation.Add(input); 
        }
        Console.WriteLine(input);
    }
}

