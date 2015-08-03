namespace QualityMethods
{
    using System;

    public class MethodsTest
    {
        private static void Main()
        {
            Console.WriteLine(Helpers.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Helpers.DigitToText(5));

            Console.WriteLine(Helpers.FindMax(5, -1, 3, 2, 14, 2, 3));

            Helpers.PrintNumberWithPrecision(1.3);
            Helpers.PrintNumberAsPercentage(0.75);
            Helpers.PrintNumberRightAligned(2.30);

            Console.WriteLine(Helpers.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Helpers.IsLineHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + Helpers.IsLineVertical(3, 3));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
