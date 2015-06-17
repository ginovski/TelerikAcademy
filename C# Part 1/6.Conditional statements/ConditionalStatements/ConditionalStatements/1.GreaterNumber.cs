using System;

class GreaterNumber
{
    static void Main(string[] args)
    {
        string numberInput = Console.ReadLine();
        int firstNumber = int.Parse(numberInput);

        numberInput = Console.ReadLine();
        int secondNumber = int.Parse(numberInput);
        int temp;
        if (firstNumber > secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        Console.WriteLine("{0} is greater than {1}", secondNumber, firstNumber);
    }
}

