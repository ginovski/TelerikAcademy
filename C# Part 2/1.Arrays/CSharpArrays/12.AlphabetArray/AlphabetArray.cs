using System;

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(Array.IndexOf(alphabet, word[i]) + " ");
        }
        Console.WriteLine();
    }
}
