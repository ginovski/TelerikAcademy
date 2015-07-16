namespace ConsoleApplication1
{
    using System;
    using System.Numerics;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            int counter = 0;
            BigInteger productOfTen = 1;
            BigInteger finalProduct = 1;
            int currentDigit = 0;

            while (true)
            {
                string number = Console.ReadLine();
                if (number == "END")
                {
                    break;
                }
                foreach (char digit in number)
                {
                    currentDigit = digit - '0';
                    if (currentDigit == 0)
                    {
                        continue;
                    }
                    if (counter % 2 != 0 && counter > 10)
                    {
                        if (currentDigit == 0 && number.Length == 1)
                        {
                            finalProduct *= 1;
                        }
                        else
                        {
                            finalProduct *= currentDigit;
                        }
                    }
                    if (counter % 2 != 0 && counter <= 10)
                    {
                        if (currentDigit == 0 && number.Length == 1)
                        {
                            productOfTen *= 1;
                        }
                        else
                        {
                            productOfTen *= currentDigit;
                        }
                    }

                }

                counter++;
            }

            Console.WriteLine(productOfTen);
            if (counter > 10)
            {
                Console.WriteLine(finalProduct);
            }
        }
    }
}
