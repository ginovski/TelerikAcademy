using System;

class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool divideBySeven = number % 7 == 0;
        bool divideByFive = number % 5 == 0;
        bool divideBoth = divideBySeven && divideByFive;
        Console.WriteLine("The number can be divided by seven and five - {0}", divideBoth);
        
    }
}

