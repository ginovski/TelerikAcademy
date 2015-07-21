namespace EnigmaCat.Utillities
{
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class MathUtillities
    {
        public static BigInteger ConvertFrom17ToDecimal(int[] number)
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

        public static BigInteger Pow(int number, int counter)
        {
            BigInteger result = 1;
            for (int i = 0; i < counter; i++)
            {
                result *= number;
            }

            return result;
        }

        public static string ConvertFromDecimalTo26(BigInteger number)
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
    }
}
