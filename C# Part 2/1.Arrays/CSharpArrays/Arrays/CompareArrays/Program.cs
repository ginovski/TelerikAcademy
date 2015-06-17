//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.
namespace CompareArrays
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter size of the arrays: ");
            int size = int.Parse(Console.ReadLine());
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];
            bool areEqual = true;

            Console.WriteLine("Enter numbers for the first array: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter numbers for the second array: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("Arrays are equal? ----> {0}", areEqual);
        }
    }
}
