namespace Assertions.Algorithms
{
    using System;
    using System.Diagnostics;

    using Utils;

    public static class SortingAlgorithms
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(arr.Length > 0, "Array is empty");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = SortingUtils.FindMinElementIndex(arr, index, arr.Length - 1);
                SortingUtils.Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
    }
}