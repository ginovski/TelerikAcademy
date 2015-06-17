//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
namespace DayOfWeek
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Today is {0}", DateTime.Now.DayOfWeek);
        }
    }
}
