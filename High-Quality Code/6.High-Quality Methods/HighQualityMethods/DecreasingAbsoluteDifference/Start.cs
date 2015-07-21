namespace DecreasingAbsoluteDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            var sequences = ParseSequences(T);

            var sequencesFromDifferences = new List<List<long>>();

            for (int i = 0; i < sequences.Count; i++)
            {
                var differences = CalculateDifferences(sequences[i]);
                sequencesFromDifferences.Add(differences);
            }

            for (int i = 0; i < sequencesFromDifferences.Count; i++)
            {
                Console.WriteLine(IsDecreasing(sequencesFromDifferences[i]));
            }
        }

        private static List<long[]> ParseSequences(int T)
        {
            var sequences = new List<long[]>();
            for (int i = 0; i < T; i++)
            {
                sequences.Add(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray());
            }

            return sequences;
        }

        private static bool IsDecreasing(List<long> list)
        {
            bool isDecreasing = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < list[i + 1] || (Math.Max(list[i], list[i + 1]) - Math.Min(list[i], list[i + 1])) != 0
                    && (Math.Max(list[i], list[i + 1]) - Math.Min(list[i], list[i + 1])) != 1)
                {
                    isDecreasing = false;
                    break;
                }
            }

            return isDecreasing;
        }

        private static List<long> CalculateDifferences(long[] sequence)
        {
            var differences = new List<long>();

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                long difference = Math.Max(sequence[i], sequence[i + 1]) - Math.Min(sequence[i], sequence[i + 1]);
                differences.Add(difference);
            }

            return differences;
        }
    }
}
