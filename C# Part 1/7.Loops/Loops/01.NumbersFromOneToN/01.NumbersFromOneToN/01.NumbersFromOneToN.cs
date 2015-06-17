using System;

class NumbersFromOneToN
{
    static void Main(string[] args)
    {
        string maxValueInput = Console.ReadLine();
        int maxValue = int.Parse(maxValueInput);

        for (int i = 1; i < maxValue; i++)
        {
            Console.WriteLine(i);
        }
    }
}

