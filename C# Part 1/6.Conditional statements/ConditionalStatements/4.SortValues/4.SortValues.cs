using System;

class SortValues
{
    static void Main(string[] args)
    {
        string numbersInput = Console.ReadLine();
        double firstNum = double.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        double secondNum = double.Parse(numbersInput);

        numbersInput = Console.ReadLine();
        double thirdNum = double.Parse(numbersInput);

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("The sequence is {0},{1},{2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("The sequence is {0},{1},{2}", firstNum, thirdNum, secondNum);
                }
            }
            else
            {
                Console.WriteLine("The sequence is {0},{1},{2}", thirdNum, firstNum, secondNum);
            }
        }
        else if (secondNum > thirdNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The sequence is {0},{1},{2}", secondNum, firstNum, thirdNum);
            }
            else
            {
                Console.WriteLine("The sequence is {0},{1},{2}", secondNum, thirdNum, firstNum);
            }
        }
        else
        {
            Console.WriteLine("The sequence is {0},{1},{2}", thirdNum, secondNum, firstNum);
        }
       
    }
}

