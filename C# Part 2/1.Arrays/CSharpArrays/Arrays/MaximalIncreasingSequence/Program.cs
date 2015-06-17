//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
namespace MaximalIncreasingSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 3, 2, 3, 4, 2, 2, 4 }; //Change the numbers to see how it works
            int counter = 1;
            int biggestCounter = 0;
            string elements = "";
            string biggestElements = "";

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    counter++;
                    elements += numbers[i] + ", ";
                }
                else
                {
                    if (counter > biggestCounter)
                    {
                        biggestCounter = counter;
                        elements += numbers[i];
                        biggestElements = elements;
                    }

                    counter = 1;
                    elements = "";
                }
            }

            Console.WriteLine("Biggest increasing sequence is: {0}", biggestElements);
        }
    }
}
