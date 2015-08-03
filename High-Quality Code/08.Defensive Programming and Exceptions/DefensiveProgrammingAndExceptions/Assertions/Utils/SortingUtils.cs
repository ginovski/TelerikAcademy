namespace Assertions.Utils
{
    using System;
    using System.Diagnostics;

    public static class SortingUtils
    {
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(arr.Length > 0, "Array is empty");

            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Invalid start index");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Invalid end index");
            Debug.Assert(startIndex <= endIndex, "Start index is bigger than end index");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}