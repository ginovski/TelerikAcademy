using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] binarySearch = { 1, 14, 2, 5, 8, 9, 15, 23, 84 };
        Array.Sort(binarySearch);
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine(Array.BinarySearch(binarySearch, element));
    }
}

