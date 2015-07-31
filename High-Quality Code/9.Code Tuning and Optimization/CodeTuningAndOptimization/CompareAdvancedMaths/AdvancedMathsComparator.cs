namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class AdvancedMathsComparator
    {
        private Stopwatch sw;

        public AdvancedMathsComparator()
        {
            this.sw = new Stopwatch();
        }

        public TimeSpan CompareSquareRoot(float number)
        {
            this.sw.Reset();
            this.sw.Start();

            float result = (float)Math.Sqrt(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSquareRoot(double number)
        {
            this.sw.Reset();
            this.sw.Start();

            double result = Math.Sqrt(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSquareRoot(decimal number)
        {
            this.sw.Reset();
            this.sw.Start();

            decimal result = (decimal)Math.Sqrt((double)number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareLogarithm(float number)
        {
            this.sw.Reset();
            this.sw.Start();

            float result = (float)Math.Log(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareLogarithm(double number)
        {
            this.sw.Reset();
            this.sw.Start();

            double result = Math.Log(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareLogarithm(decimal number)
        {
            this.sw.Reset();
            this.sw.Start();

            decimal result = (decimal)Math.Log((double)number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSinus(float number)
        {
            this.sw.Reset();
            this.sw.Start();

            float result = (float)Math.Sin(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSinus(double number)
        {
            this.sw.Reset();
            this.sw.Start();

            double result = Math.Sin(number);

            return this.sw.Elapsed;
        }

        public TimeSpan CompareSinus(decimal number)
        {
            this.sw.Reset();
            this.sw.Start();

            decimal result = (decimal)Math.Sin((double)number);

            return this.sw.Elapsed;
        }
    }
}