using System;

class MaximalSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int[] sequenceArray = new int[length];
        int counter = 1;
        int biggestCounter = 0;
        int element = 0;
        for (int i = 0; i < sequenceArray.Length; i++)
        {
            sequenceArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sequenceArray.Length - 1; i++)
        {
            if (sequenceArray[i] == sequenceArray[i + 1])
            {
                counter++;
            }
            else
            {
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    element = sequenceArray[i];
                }
                counter = 1;
            }
        }
        Console.WriteLine("Sequence length ---- {0} \nNumber ----- {1}", biggestCounter, element);
    }
}

