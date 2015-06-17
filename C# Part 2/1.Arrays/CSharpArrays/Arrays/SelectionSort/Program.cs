//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort(http://en.wikipedia.org/wiki/Selection_sort) algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
namespace SelectionSort
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 8, 5, 2, 6, 9, 3, 1, 4, 0, 7 };

            int indexMin = 0;
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                indexMin = j;
                for (int i = j + 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[indexMin])
                    {
                        indexMin = i;
                    }
                }

                //Switch places
                if (indexMin != j)
                {
                    int numberToSwitch = numbers[j];
                    numbers[j] = numbers[indexMin];
                    numbers[indexMin] = numberToSwitch;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
