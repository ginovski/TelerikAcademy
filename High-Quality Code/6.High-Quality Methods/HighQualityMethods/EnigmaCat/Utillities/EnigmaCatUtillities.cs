namespace EnigmaCat.Utillities
{
    using System.Collections.Generic;
    using System.Numerics;

    public class EnigmaCatUtillities
    {
        public static ICollection<string> ConvertDecimalCatNumbersTo26(IList<BigInteger> wordsInDecimal)
        {
            var wordsIn26 = new List<string>();
            for (int i = 0; i < wordsInDecimal.Count; i++)
            {
                wordsIn26.Add(MathUtillities.ConvertFromDecimalTo26(wordsInDecimal[i]));
            }

            return wordsIn26;
        }

        public static IList<BigInteger> ConvertCatNumbersToDecimal(List<int[]> catWordsAsNumbers)
        {
            var wordsInDecimal = new List<BigInteger>();
            for (int i = 0; i < catWordsAsNumbers.Count; i++)
            {
                wordsInDecimal.Add(MathUtillities.ConvertFrom17ToDecimal(catWordsAsNumbers[i]));
            }

            return wordsInDecimal;
        }

        public static List<int[]> ConvertFromCatWordsToDigits(string[] catWords)
        {
            var numbers = new List<int[]>();
            for (int i = 0; i < catWords.Length; i++)
            {
                string word = catWords[i];
                int[] number = new int[word.Length];
                for (int j = 0; j < word.Length; j++)
                {
                    number[j] = word[j] - 'a';
                }

                numbers.Add(number);
            }

            return numbers;
        }
    }
}
