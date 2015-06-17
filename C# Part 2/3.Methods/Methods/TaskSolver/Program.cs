//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
namespace TaskSolver
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintMenu();
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                Console.WriteLine("Enter positive number: ");
                decimal number = decimal.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Number must be positive");
                    return;
                }

                decimal reversed = ReverseNumber(number);
                Console.WriteLine(reversed);
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("Enter numbers length: ");
                int length = int.Parse(Console.ReadLine());
                if (length <= 0)
                {
                    Console.WriteLine("There should be at least one number");
                    return;
                }

                decimal[] numbers = new decimal[length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("numbers[{0}] = ", i);
                    numbers[i] = decimal.Parse(Console.ReadLine());
                }

                decimal average = CalculateAverage(numbers);
                Console.WriteLine("Average is: {0}", average);
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Enter value for a (a != 0): ");
                decimal a = decimal.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("'a' should not be zero");
                    return;
                }

                Console.WriteLine("Enter value for b: ");
                decimal b = decimal.Parse(Console.ReadLine());

                decimal solution = SolveLinearEquation(a, b);
                Console.WriteLine("The solution of the equation {0} * x + {1} = 0 is: {2}", a, b, solution);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Choose one of the options: ");
            Console.WriteLine("1. Reverse digits of a number");
            Console.WriteLine("2. Calculate average of numbers");
            Console.WriteLine("3. Solve linear equation (a * x + b = 0)");
        }

        private static decimal ReverseNumber(decimal number)
        {
            string reversed = "";
            string numberAsString = number.ToString();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversed += numberAsString[i];
            }

            return decimal.Parse(reversed);
        }

        private static decimal CalculateAverage(params decimal[] numbers)
        {
            decimal sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }

        private static decimal SolveLinearEquation(decimal a, decimal b)
        {
            decimal x = (b * -1) / a;

            return x;
        }
    }
}
