using System;

class SignOfTheSum
{
    static void Main(string[] args)
    {
        string numbersInput = Console.ReadLine();
        double firstNum = double.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        double secondNum = double.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        double thirdNum = double.Parse(numbersInput);

        byte sign = 0;

        if (firstNum < 0)
        {
            sign++;
        }
        if (secondNum < 0)
        {
            sign++;
        }
        if (thirdNum < 0)
        {
            sign++;
        }
        if (firstNum * secondNum * thirdNum != 0)
        {


            if (sign % 2 == 0)
            {
                Console.WriteLine("The sign of the product will be " + "+");
            }
            else
            {
                Console.WriteLine("The sign of the product will be " + "-");
            }
        }
        else
        {
            Console.WriteLine("The product is 0");
        }
    }
}

