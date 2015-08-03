namespace Assertions.Algorithms
{
    using System;
    using System.Diagnostics;

    public class SearchingAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
                    where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(arr.Length > 0, "Array is empty");

            Debug.Assert(value != null, "Searched value is null");

            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Invalid start index");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Invalid end index");
            Debug.Assert(startIndex <= endIndex, "Start index is bigger than end index");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}