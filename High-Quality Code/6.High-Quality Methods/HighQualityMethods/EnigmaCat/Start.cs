//C#2 Exam Task 1
namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    using EnigmaCat.Utillities;

    public class Start
    {
        public static void Main()
        {
            string[] catWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var catWordsAsNumbers = EnigmaCatUtillities.ConvertFromCatWordsToDigits(catWords);

            var wordsInDecimal = EnigmaCatUtillities.ConvertCatNumbersToDecimal(catWordsAsNumbers);
            var wordsIn26 = EnigmaCatUtillities.ConvertDecimalCatNumbersTo26(wordsInDecimal);

            Console.WriteLine(string.Join(" ", wordsIn26));
        }
    }
}
