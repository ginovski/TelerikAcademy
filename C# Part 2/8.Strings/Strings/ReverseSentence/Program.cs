namespace ReverseSentence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] words = text.Split(new char[] { ' ', '!'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(words[i]);
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine("!");
        }
    }
}
