namespace Exceptions.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudentSystemUtils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array can not be null or empty");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index is out of range");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count must be positive");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("String can not be null or empty");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count is out of string range");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be positive");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}