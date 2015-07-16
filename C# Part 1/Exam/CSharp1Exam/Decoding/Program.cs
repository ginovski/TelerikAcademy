namespace Decoding
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            decimal currentEncodedChar = 0;

            for (int i = 0; i < text.Length; i++)
            {
                currentEncodedChar = (decimal)text[i];
                if (text[i] == '@')
                {
                    break;
                }

                else if (char.IsLetter(text[i]))
                {
                    currentEncodedChar = currentEncodedChar * salt + 1000;
                }

                else if (char.IsDigit(text[i]))
                {
                    currentEncodedChar = currentEncodedChar + salt + 500;
                }
                else
                {
                    currentEncodedChar = currentEncodedChar - salt;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:f2}", currentEncodedChar / 100);
                }
                else
                {
                    Console.WriteLine("{0}", currentEncodedChar * 100);
                }
            }
        }
    }
}
