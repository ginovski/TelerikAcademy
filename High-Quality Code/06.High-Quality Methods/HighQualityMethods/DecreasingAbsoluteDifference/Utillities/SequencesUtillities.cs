namespace DecreasingAbsoluteDifference.Utillities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SequencesUtillities
    {
        public static List<long[]> ParseSequences(int sequencesCount)
        {
            var sequences = new List<long[]>();
            for (int i = 0; i < sequencesCount; i++)
            {
                sequences.Add(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray());
            }

            return sequences;
        }

        public static bool IsDecreasing(List<long> list)
        {
            bool isDecreasing = true;
            for (int index = 0; index < list.Count - 1; index++)
            {
                if (IsIncreasing(list, index))
                {
                    isDecreasing = false;
                    break;
                }
            }

            return isDecreasing;
        }

        public static bool IsIncreasing(List<long> list, int index)
        {
            bool isMaxMinusMinEqualZero = (Math.Max(list[index], list[index + 1]) - Math.Min(list[index], list[index + 1])) != 0;
            bool isMaxMinusMinEqualOne = (Math.Max(list[index], list[index + 1]) - Math.Min(list[index], list[index + 1])) != 1;

            return list[index] < list[index + 1] || (isMaxMinusMinEqualZero && isMaxMinusMinEqualOne);
        }

        public static List<long> CalculateDifferences(long[] sequence)
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
