using System;

class GreaterThanTheNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter one number");
        string numbersInput = Console.ReadLine();
        double numberOne = double.Parse(numbersInput);

        Console.WriteLine("Enter another number");
        numbersInput = Console.ReadLine();
        double numberTwo = double.Parse(numbersInput);

        double greaterNum = Math.Max(numberOne, numberTwo);

        Console.WriteLine("The greater number is   {0}", greaterNum);
    }
}

