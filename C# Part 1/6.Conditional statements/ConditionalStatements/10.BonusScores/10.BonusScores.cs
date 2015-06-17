using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a digit [1-9]");
        string digitInput = Console.ReadLine();
        byte digit = byte.Parse(digitInput);

        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(digit * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(digit * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(digit * 1000);
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
}

