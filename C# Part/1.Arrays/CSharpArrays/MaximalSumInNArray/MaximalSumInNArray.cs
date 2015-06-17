using System;

class MaximalSumInNArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] nArray = new int[n];
        if (k > n)
        {
            Console.WriteLine("Ne staa");
            return;
        }
        for (int i = 0; i < nArray.Length; i++)
        {
            nArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nArray);

        for (int i = nArray.Length; i > nArray.Length - k; i--)
        {
            sum += nArray[i - 1]; 
        }
        Console.WriteLine(sum);
    }
}

