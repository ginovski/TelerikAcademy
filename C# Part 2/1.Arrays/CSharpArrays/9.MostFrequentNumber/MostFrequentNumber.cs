using System;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int[] frequentNumber = { 4, 1, 1, 4, 3, 3, 4, 4, 1, 2, 4, 9, 3};
        Array.Sort(frequentNumber);
        int counter = 1;
        int biggestCounter = 0;
        int frequentNum = 0;
        for (int i = 0; i < frequentNumber.Length - 1; i++)
        {
            if (frequentNumber[i] == frequentNumber[i + 1])
            {
                counter++;
            }
            else 
            {
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    frequentNum = frequentNumber[i];
                }
                counter = 1;
            }
        }
        Console.WriteLine("{0} ({1} times)", frequentNum, biggestCounter);
    }
}

