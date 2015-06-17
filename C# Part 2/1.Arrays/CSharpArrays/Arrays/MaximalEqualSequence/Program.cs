//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
namespace MaximalEqualSequence
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 }; //Change the elements to see how it works :)
            int counter = 1;
            int biggestCounter = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > biggestCounter)
                    {
                        biggestCounter = counter;
                        element = numbers[i];
                    }

                    counter = 1;
                }
            }

            int[] maxSequence = new int[biggestCounter];
            for (int i = 0; i < biggestCounter; i++)
            {
                maxSequence[i] = element;
            }
            Console.WriteLine("Max sequence is: {0}", string.Join(", ", maxSequence));
        }
    }
}
