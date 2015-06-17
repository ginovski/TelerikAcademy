using System;

class BiggestNumber
{
    static void Main(string[] args)
    {
        string numbersInput = Console.ReadLine();
        int firstNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int secondNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int thirdNum = int.Parse(numbersInput);

        if (firstNum > secondNum && firstNum > thirdNum)
        {
            Console.WriteLine("{0} is greatest", firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum)
        {
            Console.WriteLine("{0} is greatest", secondNum);
        }
        else
        {
            Console.WriteLine("{0} is greatest", thirdNum);
        }
    }
}

