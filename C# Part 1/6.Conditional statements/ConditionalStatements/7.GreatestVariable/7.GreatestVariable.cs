using System;

class GreatestVariable
{
    static void Main(string[] args)
    {
        string numberInput = Console.ReadLine();
        int numberOne = int.Parse(numberInput);

        numberInput = Console.ReadLine();
        int numberTwo = int.Parse(numberInput);

        numberInput = Console.ReadLine();
        int numberThree = int.Parse(numberInput);

        numberInput = Console.ReadLine();
        int numberFour = int.Parse(numberInput);

        numberInput = Console.ReadLine();
        int numberFive = int.Parse(numberInput);

        int greatest = numberOne;

        if (greatest < numberTwo)
        {
            greatest = numberTwo;
        }
        if (greatest < numberThree)
        {
            greatest = numberThree;
        }
        if (greatest < numberFour)
        {
            greatest = numberFour;
        }
        if (greatest < numberFive)
        {
            greatest = numberFive;
        }
        Console.WriteLine("The greatest number is {0}", greatest);
    }
}

