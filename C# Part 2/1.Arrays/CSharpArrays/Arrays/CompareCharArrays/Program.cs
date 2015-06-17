//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
namespace CompareCharArrays
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter size of the arrays: ");
            int size = int.Parse(Console.ReadLine());
            char[] firstArray = new char[size];
            char[] secondArray = new char[size];
            bool areEqual = true;

            Console.WriteLine("Enter numbers for the first array: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter numbers for the second array: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
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
