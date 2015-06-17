using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool thirdDigitOfTheNumber = (number / 100) % 10 == 7;

        Console.WriteLine("Third digit if the number is 7 - {0}", thirdDigitOfTheNumber);
    }
}

