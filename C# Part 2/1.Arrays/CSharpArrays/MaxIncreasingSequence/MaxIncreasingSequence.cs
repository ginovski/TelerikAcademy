using System;

class MaxIncreasingSequence
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int[] sequenceArray = new int[length];
        int counter = 1;
        int biggestCounter = 0;
        string element = "";
        string biggestElement = "";
        for (int i = 0; i < sequenceArray.Length; i++)
        {
            sequenceArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sequenceArray.Length - 1; i++)
        {
            if (sequenceArray[i] < sequenceArray[i + 1])
            {
                counter++;
                element += sequenceArray[i] + " ";
            }
            else
            {
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    element += sequenceArray[i] + " ";
                    biggestElement = element;
                }
                counter = 1;
                element = "";
            }
        }
        Console.WriteLine(biggestElement);
    }
}

