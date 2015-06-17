namespace FormatNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Number in decimal: {0}", number);
            Console.WriteLine("Number in hexadecimal: {0:X}", number);
            Console.WriteLine("Number in procent: {0:#0.##%}", number);

        }
    }
}
