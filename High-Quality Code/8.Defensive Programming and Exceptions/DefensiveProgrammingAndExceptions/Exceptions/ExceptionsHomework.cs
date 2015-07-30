namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    using Utils;

    public class ExceptionsHomework
    {
        private static void Main()
        {
            var substr = StudentSystemUtils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = StudentSystemUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = StudentSystemUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = StudentSystemUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(StudentSystemUtils.ExtractEnding("I love C#", 2));
            Console.WriteLine(StudentSystemUtils.ExtractEnding("Nakov", 4));
            Console.WriteLine(StudentSystemUtils.ExtractEnding("beer", 4));
            // Throws error because count is bigger than string length
            // Console.WriteLine(StudentSystemUtils.ExtractEnding("Hi", 100));

            if (StudentSystemUtils.CheckPrime(23))
            {
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime");
            }

            if (StudentSystemUtils.CheckPrime(33))
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime");
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}