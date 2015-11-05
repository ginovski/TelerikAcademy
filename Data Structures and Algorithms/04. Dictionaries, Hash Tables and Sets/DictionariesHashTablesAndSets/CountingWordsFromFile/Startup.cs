// Write a program that counts how many times each word from given text file words.txt appears in it.The character casing differences should be ignored.The result words should be ordered by their number of occurrences in the text.Example:
// This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
// is -> 2
// the -> 2
// this -> 3
// text -> 6
namespace CountingWordsFromFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static IDictionary<string, int> CountWords(string text)
        {
            var wordsCount = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', '.', ',', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                string wordLower = word.ToLower();
                if (!wordsCount.ContainsKey(wordLower))
                {
                    wordsCount[wordLower] = 0;
                }

                wordsCount[wordLower]++;
            }

            return wordsCount;
        }

        public static void Main()
        {
            string text = File.ReadAllText(Directory.GetCurrentDirectory() + "/words.txt");

            var wordsCount = CountWords(text);
            var orderedWords = wordsCount.OrderBy(w => w.Value);

            foreach (var wordCount in orderedWords)
            {
                Console.WriteLine("{0} -> {1}", wordCount.Key, wordCount.Value);
            }
        }
    }
}