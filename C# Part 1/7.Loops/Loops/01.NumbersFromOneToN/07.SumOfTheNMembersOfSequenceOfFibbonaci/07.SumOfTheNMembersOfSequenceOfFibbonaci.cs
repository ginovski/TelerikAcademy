using System;

class SumOfTheNMembersOfSequenceOfFibbonaci
{
    static void Main(string[] args)
    {
        string maxValueInput = Console.ReadLine();
        int maxValue = int.Parse(maxValueInput);

        ulong previousNumber = 0;
        ulong numberTwo = 1;
        ulong numberThree;
        ulong result = previousNumber + numberTwo;

        for (int i = 1; i < maxValue; i++)
        {
            numberThree = previousNumber + numberTwo;
            result += numberThree;
            previousNumber = numberTwo;
            numberTwo = numberThree;
            
        }
        Console.WriteLine(result);
    }
}

