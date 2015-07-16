namespace ThreeNumbers
{
    using System;

    public class Program
    {
        private static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal biggest = 0;
            decimal smallest = 0;
            decimal arithmeticMean = (a + b + c) / 3;

            if (a >= b && a >= c)
            {
                biggest = a;
            }
            else if (b >= a && b >= c)
            {
                biggest = b;
            }
            else
            {
                biggest = c;
            }

            if (a <= b && a <= c)
            {
                smallest = a;
            }
            else if (b <= c && b <= a)
            {
                smallest = b;
            }
            else
            {
                smallest = c;
            }

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:f2}", arithmeticMean);
        }
    }
}
