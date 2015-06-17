using System;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = new int[20];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i * 5;
            Console.Write(intArray[i] + " ");
        }
        Console.WriteLine();
    }
}

