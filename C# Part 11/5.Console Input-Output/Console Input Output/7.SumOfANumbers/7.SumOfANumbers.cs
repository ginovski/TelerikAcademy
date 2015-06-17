using System;

class SumOfANumbers
{
    static void Main()
    {
        Console.WriteLine("Write a number");
        string numbersInput = Console.ReadLine();
        double number = double.Parse(numbersInput);
        double otherNumbers;
        double result = 0;
        Console.WriteLine("Write {0} other numbers", number);
        for (int i = 0; i < number; i++)
        {
            numbersInput = Console.ReadLine();
            otherNumbers = double.Parse(numbersInput);
            result += otherNumbers;
        }
        Console.WriteLine("The sum of the numbers is {0}", result);
    }
}

