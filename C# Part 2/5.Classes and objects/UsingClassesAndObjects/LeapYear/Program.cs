//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
namespace LeapYear
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} is leap --> {1}", year, DateTime.IsLeapYear(year));
        }
    }
}
