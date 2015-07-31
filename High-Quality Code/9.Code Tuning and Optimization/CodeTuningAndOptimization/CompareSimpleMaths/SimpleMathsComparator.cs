namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class SimpleMathsComparator
    {
        private Stopwatch sw;

        public SimpleMathsComparator()
        {
            this.sw = new Stopwatch();
        }

        public TimeSpan CompareAdding(int first, int second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Add(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareAdding(long first, long second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Add(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareAdding(float first, float second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Add(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareAdding(double first, double second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Add(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareAdding(decimal first, decimal second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Add(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSubstracting(int first, int second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Substract(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSubstracting(long first, long second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Substract(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSubstracting(float first, float second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Substract(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSubstracting(double first, double second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Substract(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSubstracting(decimal first, decimal second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Substract(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareMultiplication(int first, int second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Multiply(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareMultiplication(long first, long second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Multiply(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareMultiplication(float first, float second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Multiply(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareMultiplication(double first, double second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Multiply(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareMultiplication(decimal first, decimal second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Multiply(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareDivision(int first, int second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Divide(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareDivision(long first, long second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Divide(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareDivision(float first, float second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Divide(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareDivision(double first, double second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Divide(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareDivision(decimal first, decimal second)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Divide(first, second);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareIncrement(int number)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Increment(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareIncrement(long number)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Increment(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareIncrement(float number)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Increment(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareIncrement(double number)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Increment(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareIncrement(decimal number)
        {
            this.sw.Reset();
            this.sw.Start();

            SimpleMaths.Increment(number);

            return this.sw.Elapsed;
        }
    }
}