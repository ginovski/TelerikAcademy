using System;

class MinAndMaxNumber
{
    static void Main(string[] args)
    {
        string nInput = Console.ReadLine();
        int n = int.Parse(nInput);
        int[] numberArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
            
        }
        int minValue = numberArray[0];
        int maxValue = numberArray[0];

        for (int i = 0; i < numberArray.Length; i++)
        {
            if (maxValue < numberArray[i])
            {
                maxValue = numberArray[i];
            }
            if (minValue > numberArray[i])
            {
                minValue = numberArray[i];
            }
        }
        Console.WriteLine(maxValue);
        Console.WriteLine(minValue);
    }
}

