using System;

class SortAlgorithm
{
    static void Main()
    {
        int[] array = { -2, 1, -2, 5, 3, 3, 4, };

        int startingPosition = 0;
        while (startingPosition <= array.Length - 1)
        {
            int currentMinIndex = 0;
            int currentMin = int.MaxValue;
            for (int i = startingPosition; i < array.Length; i++)
            {
                if (array[i] < currentMin)
                {
                    currentMin = array[i];
                    currentMinIndex = i;
                }
            }
            int temp = array[startingPosition];

            array[startingPosition] = currentMin;
            array[currentMinIndex] = temp;
            startingPosition++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

