//Write a program that finds the most frequent number in an array.
namespace FrequentNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int frequencyCounter = 1;
            int frequentNumber = 0;
            int bestFrequencyCounter = int.MinValue;

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    frequencyCounter++;
                }
                else
                {
                    if (frequencyCounter > bestFrequencyCounter)
                    {
                        bestFrequencyCounter = frequencyCounter;
                        frequentNumber = numbers[i];
                    }

                    frequencyCounter = 1;
                }
            }

            Console.WriteLine("Most frequent number is: {0}({1} times)", frequentNumber, bestFrequencyCounter);
        }
    }
}
