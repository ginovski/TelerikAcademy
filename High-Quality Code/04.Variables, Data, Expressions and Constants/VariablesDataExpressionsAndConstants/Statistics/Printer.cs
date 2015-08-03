// Refactor the following code to apply variable usage and naming best practices
namespace Statistics
{
    using System;

    public class Printer
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            this.Print(max);

            double min = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            this.Print(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            this.Print(sum / count);
        }

        private void Print(double value)
        {
            Console.WriteLine(value);
        }
    }
}
