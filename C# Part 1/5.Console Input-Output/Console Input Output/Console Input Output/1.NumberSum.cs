using System;

class NumberSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        string input = Console.ReadLine();

        int firstNumber = int.Parse(input);

        Console.WriteLine("Enter second number");
        input = Console.ReadLine();

        int secondNumber = int.Parse(input);
        
        Console.WriteLine("Enter third number");
        input = Console.ReadLine();

        int thirdNumber = int.Parse(input);
        int result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the three numbers is {0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, result );
    }
}

