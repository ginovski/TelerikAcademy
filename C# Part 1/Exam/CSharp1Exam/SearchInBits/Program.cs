namespace SearchInBits
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] bitsOfNumbers = new string[n];
            uint currentNumber = 0;
            string bitsOfS = Convert.ToString(s, 2).PadLeft(4, '0');
            int occurences = 0;
            int index = 0;
            int nextIndex = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = uint.Parse(Console.ReadLine());
                bitsOfNumbers[i] = Convert.ToString(currentNumber, 2);
            }

            foreach (var bits in bitsOfNumbers)
            {
                string currentBits = bits;
                if (currentBits.Length < 30)
                {
                    currentBits = currentBits.PadLeft(30, '0');
                }
                if (currentBits.Length > 30)
                {
                    currentBits = currentBits.Substring(bits.Length - 30, 30);
                }
                while (index != -1)
                {
                    index = currentBits.IndexOf(bitsOfS, nextIndex);
                    if (index != -1)
                    {
                        occurences++;
                        nextIndex = index + 1;
                    }
                }
                index = 0;
                nextIndex = 0;
            }

            Console.WriteLine(occurences);
        }
    }
}

