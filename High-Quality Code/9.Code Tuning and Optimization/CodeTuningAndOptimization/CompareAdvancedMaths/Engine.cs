namespace CompareAdvancedMaths
{
    using System;

    public class Engine
    {
        private static void Main(string[] args)
        {
            var comparator = new AdvancedMathsComparator();

            float numberFloat = 6.88888f;
            double numberDouble = 8.43412323;
            decimal numberDecimal = 10.324233242m;

            Console.WriteLine("Float square root: {0}", comparator.CompareSquareRoot(numberFloat));
            Console.WriteLine("Double square root: {0}", comparator.CompareSquareRoot(numberDouble));
            Console.WriteLine("Decimal square root: {0}", comparator.CompareSquareRoot(numberDecimal));

            Console.WriteLine();

            Console.WriteLine("Float logarithm: {0}", comparator.CompareLogarithm(numberFloat));
            Console.WriteLine("Double logarithm: {0}", comparator.CompareLogarithm(numberDouble));
            Console.WriteLine("Decimal logarithm: {0}", comparator.CompareLogarithm(numberDecimal));

            Console.WriteLine();

            Console.WriteLine("Float sinus: {0}", comparator.CompareSinus(numberFloat));
            Console.WriteLine("Double sinus: {0}", comparator.CompareSinus(numberDouble));
            Console.WriteLine("Decimal sinus: {0}", comparator.CompareSinus(numberDecimal));
        }
    }
}