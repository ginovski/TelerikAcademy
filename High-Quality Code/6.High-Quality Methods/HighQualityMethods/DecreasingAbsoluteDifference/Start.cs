//C#2 Exam Task 2
namespace DecreasingAbsoluteDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DecreasingAbsoluteDifference.Utillities;

    public class Start
    {
        public static void Main()
        {
            int sequencesCount = int.Parse(Console.ReadLine());
            var sequences = SequencesUtillities.ParseSequences(sequencesCount);

            var sequencesFromDifferences = new List<List<long>>();

            for (int i = 0; i < sequences.Count; i++)
            {
                var differences = SequencesUtillities.(sequences[i]);
                sequencesFromDifferences.Add(differences);
            }

            for (int i = 0; i < sequencesFromDifferences.Count; i++)
            {
                Console.WriteLine(SequencesUtillities.(sequencesFromDifferences[i]));
            }
        }
    }
}
