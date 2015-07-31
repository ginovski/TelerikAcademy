namespace CompareSimpleMaths
{
    using System;

    public class Engine
    {
        private static void Main()
        {
            var comparator = new SimpleMathsComparator();

            int firstInt = 10000;
            int secondInt = 20000;
            long firstLong = 1000000000;
            long secondLong = 20000000000;
            float firstFloat = 50.5f;
            float secondFloat = 80.33333f;
            double firstDouble = 20.55555555555;
            double secondDouble = 50.444;
            decimal firstDecimal = 10.5555555555555m;
            decimal secondDecimal = 12.66666m;

            Console.WriteLine("Adding ints: {0}", comparator.CompareAdding(firstInt, secondInt));
            Console.WriteLine("Adding longs: {0}", comparator.CompareAdding(firstLong, secondLong));
            Console.WriteLine("Adding floats: {0}", comparator.CompareAdding(firstFloat, secondFloat));
            Console.WriteLine("Adding doubles: {0}", comparator.CompareAdding(firstDouble, secondDouble));
            Console.WriteLine("Adding decimals: {0}", comparator.CompareAdding(firstDecimal, secondDecimal));

            Console.WriteLine();

            Console.WriteLine("Substracting ints: {0}", comparator.CompareSubstracting(firstInt, secondInt));
            Console.WriteLine("Substracting longs: {0}", comparator.CompareSubstracting(firstLong, secondLong));
            Console.WriteLine("Substracting floats: {0}", comparator.CompareSubstracting(firstFloat, secondFloat));
            Console.WriteLine("Substracting doubles: {0}", comparator.CompareSubstracting(firstDouble, secondDouble));
            Console.WriteLine("Substracting decimals: {0}", comparator.CompareSubstracting(firstDecimal, secondDecimal));

            Console.WriteLine();

            Console.WriteLine("Multiplying ints: {0}", comparator.CompareMultiplication(firstInt, secondInt));
            Console.WriteLine("Multiplying longs: {0}", comparator.CompareMultiplication(firstLong, secondLong));
            Console.WriteLine("Multiplying floats: {0}", comparator.CompareMultiplication(firstFloat, secondFloat));
            Console.WriteLine("Multiplying doubles: {0}", comparator.CompareMultiplication(firstDouble, secondDouble));
            Console.WriteLine("Multiplying decimals: {0}", comparator.CompareMultiplication(firstDecimal, secondDecimal));

            Console.WriteLine();

            Console.WriteLine("Dividing ints: {0}", comparator.CompareDivision(firstInt, secondInt));
            Console.WriteLine("Dividing longs: {0}", comparator.CompareDivision(firstLong, secondLong));
            Console.WriteLine("Dividing floats: {0}", comparator.CompareDivision(firstFloat, secondFloat));
            Console.WriteLine("Dividing doubles: {0}", comparator.CompareDivision(firstDouble, secondDouble));
            Console.WriteLine("Dividing decimals: {0}", comparator.CompareDivision(firstDecimal, secondDecimal));

            Console.WriteLine();

            Console.WriteLine("Incrementing int: {0}", comparator.CompareIncrement(firstInt));
            Console.WriteLine("Incrementing long: {0}", comparator.CompareIncrement(firstLong));
            Console.WriteLine("Incrementing float: {0}", comparator.CompareIncrement(firstFloat));
            Console.WriteLine("Incrementing double: {0}", comparator.CompareIncrement(firstDouble));
            Console.WriteLine("Incrementing decimal: {0}", comparator.CompareIncrement(firstDecimal));
        }
    }
}