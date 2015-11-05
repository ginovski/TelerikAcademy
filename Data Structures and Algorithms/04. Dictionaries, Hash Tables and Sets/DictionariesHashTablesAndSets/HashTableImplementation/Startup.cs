namespace HashTableImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var hashTable = new HashTable<int, int>();
            for (int i = 0; i < 100000; i++)
            {
                hashTable.Add(i, i + 2);
            }

            foreach (var item in hashTable)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}