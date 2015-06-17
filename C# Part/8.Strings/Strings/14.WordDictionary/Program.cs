//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
namespace WordDictionary
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

            wordDictionary.Add(".net", "platform for applications from Microsoft");
            wordDictionary.Add("clr", "managed execution environment for .NET");
            wordDictionary.Add("namespace", "hierarchical organization of classes");

            string word = Console.ReadLine();
            word = word.ToLower();

            try
            {
                Console.WriteLine(wordDictionary[word]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("Word is not in the dictionary");
            }
        }
    }
}
