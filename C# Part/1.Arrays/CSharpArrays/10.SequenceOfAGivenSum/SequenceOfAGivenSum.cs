using System;

class SequenceOfAGivenSum
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 6, 3, 1, 4, 2, 5, 8 };
        int sum = int.Parse(Console.ReadLine());
        int equalSum = 0;
        int startIndex = 0;
        int endIndex = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            equalSum = arr[i];
            startIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                equalSum += arr[j];
                endIndex = j;

                if (equalSum == sum)
                {
                    Console.Write("{");
                    for (int k = startIndex; k <= endIndex; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    Console.Write("}");
                }
            }
        }
        Console.WriteLine();
    }
}

