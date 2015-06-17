namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string[] catWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var catWordsAsNumbers = ConvertFromWordsToDigits(catWords);
            var wordsInDecimal = new List<BigInteger>();
            for (int i = 0; i < catWordsAsNumbers.Count; i++)
            {
                wordsInDecimal.Add(ConvertFrom17ToDecimal(catWordsAsNumbers[i]));
            }

            var wordsIn26 = new List<string>();
            for (int i = 0; i < wordsInDecimal.Count; i++)
            {
                wordsIn26.Add(ConvertFromDecimalTo26(wordsInDecimal[i]));
            }

            Console.WriteLine(string.Join(" ", wordsIn26));

        }

        private static string ConvertFromDecimalTo26(BigInteger number)
        {
            int systemBase = 26;
            var reminders = new List<List<BigInteger>>();
            
            var numberAsString = new StringBuilder();

            while (number > 0)
            {
                var currentNumber = new List<BigInteger>();
                currentNumber.Add(number % systemBase);
                reminders.Add(currentNumber);
                number /= systemBase;
            }

            for (int i = reminders.Count - 1; i >= 0; i--)
            {
                var currentReminder = reminders[i];
                for (int j = 0; j < currentReminder.Count; j++)
                {
                    numberAsString.Append((char)(currentReminder[j] + 97));
                }
            }

            return numberAsString.ToString();
        }
        //Check for performance
        private static List<int[]> ConvertFromWordsToDigits(string[] catWords)
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

        private static BigInteger ConvertFrom17ToDecimal(int[] number)
        {
            BigInteger result = 0;
            int counter = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i] * Pow(17, counter);
                counter++;
            }

            return result;
        }

        private static BigInteger Pow(int number, int counter)
        {
            BigInteger result = 1;
            for (int i = 0; i < counter; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
