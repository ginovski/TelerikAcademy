using System;

class MaximalSumOfRealNumbers
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = 0;
        int sum = 0;
        int startIndex = 0;
        int endIndex = 1;

        for (int i = 0, j = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[j] <= 0)
            {
                j++;
            }
            else if (sum + numbers[i] > maxSum)
            {
                sum += numbers[i];
                maxSum = sum;
                startIndex = j;
                endIndex = i;
            }
            else if ((i < numbers.Length - 1) && (numbers[i] + numbers[i + 1] > 0))
            {
                sum += numbers[i];
            }
            else
            {
                sum = 0;
                i = j;
                j++;
            }
        }
        Console.WriteLine(maxSum);
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

