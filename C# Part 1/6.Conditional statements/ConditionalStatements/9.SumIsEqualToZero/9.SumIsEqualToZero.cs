using System;

class SumIsEqualToZero
{
    static void Main(string[] args)
    {
        string numbersInput = Console.ReadLine();
        int firstNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int secondNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int thirdNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int fourthNum = int.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        int fifthNum = int.Parse(numbersInput);

        if (firstNum + secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3}, {4}, {5} is equal to zero", firstNum, secondNum, thirdNum, fourthNum, fifthNum);
        }
        if (firstNum + secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is equal to zero", firstNum, secondNum, thirdNum, fourthNum);
        }
        if (firstNum + secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is equal to zero", firstNum, secondNum, thirdNum, fifthNum);
        }
        if (firstNum + secondNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is equal to zero", firstNum, secondNum, fourthNum, fifthNum);
        }
        if (firstNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is equal to zero", firstNum, thirdNum, fourthNum, fifthNum);
        }
        if (secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is equal to zero", secondNum, thirdNum, fourthNum, fifthNum);
        }
        if (firstNum + secondNum + thirdNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, secondNum, thirdNum);
        }
        if (firstNum + secondNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, secondNum, fourthNum);
        }
        if (firstNum + secondNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, secondNum, fifthNum);
        }
        if (firstNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, thirdNum, fourthNum);
        }
        if (firstNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, thirdNum, fifthNum);
        }
        if (firstNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", firstNum, fourthNum, fifthNum);
        }
        if (secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", secondNum, thirdNum, fourthNum);
        }
        if (secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", secondNum, thirdNum, fifthNum);
        }
        if (secondNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", secondNum, fourthNum, fifthNum);
        }
        if (thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is equal to zero", thirdNum, fourthNum, fifthNum);
        }
        if (firstNum + secondNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", firstNum, secondNum);
        }
        if (firstNum + thirdNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", firstNum, thirdNum);
        }
        if (firstNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", firstNum, fourthNum);
        }
        if (firstNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", firstNum, fifthNum);
        }
        if (secondNum + thirdNum == 0)
        {
           Console.WriteLine("The sum of {0}, {1} is equal to zero", secondNum, thirdNum); 
        }
        if (secondNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", secondNum, fourthNum);
        }
        if (secondNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", secondNum, fifthNum);
        }
        if (thirdNum + fourthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", thirdNum, fourthNum);
        }
        if (thirdNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", thirdNum, fifthNum);
        }
        if (fourthNum + fifthNum == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is equal to zero", fourthNum, fifthNum);
        }
    }
}


