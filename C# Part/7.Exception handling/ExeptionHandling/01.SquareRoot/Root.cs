using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Root
    {
        private static double Sqrt(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                double root = Sqrt(number);
                Console.WriteLine("The square root of {0} is: {1}", number, root);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You have to enter positive number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
